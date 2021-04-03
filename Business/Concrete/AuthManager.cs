using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private ICustomerService _customerService;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, ICustomerService customerService)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _customerService = customerService;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.RegisterSuccess);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.ErrorPassword);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAvailable);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.TokenCreated);
        }
        [TransactionScopeAspect]
        public IDataResult<UserForUpdateDto> Update(UserForUpdateDto userForUpdateDto)
        {
            var user = _userService.GetById(userForUpdateDto.UserId);
            var customer = _customerService.GetByUserId(user.Id);
            var newUser = new User
            {
                Id=user.Id,
                Email = userForUpdateDto.Email,
                FirstName = userForUpdateDto.FirstName,
                LastName = userForUpdateDto.LastName,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt,
                Status = true
            };
            var newCustomer = new Customer
            {
                 CustomerId=customer.Data.CustomerId,
                 UserId=customer.Data.UserId,
                 CompanyName=userForUpdateDto.CompanyName
            };

            _userService.Update(newUser);
            _customerService.Update(newCustomer);
            return new SuccessDataResult<UserForUpdateDto>(userForUpdateDto, Messages.UserUpdated);
        }
      
    }
}
