# ReCapProject

![](baslik.png) 
#

<b>ReCapProject, SOLID prensiplerine bağlı kalınarak ve N-Katmalı mimari yapısıyla C# programlama diline ait; henüz geliştirilme aşamasında olan bir araç kiralama projesidir.

![](database.png)

#
 
<b>Veritabanı, Visual Studio 2019 içindeki SQL Server Object Explorer kısmından yola çıkılarak oluşturulmuştur. Alt kısımda bu veritabanına ait tabloların alan isimlerini ve veri tiplerini görebilirsiniz.  

![](tables.png) 



![](Layers.png) 

#

<b>ReCapProject; Entities, DataAccess ve Business katmanlarından oluşmaktadır. Başlangıç olarak bu katmanlardaki operasyonların simülasyonu için ConsoleUI katmanı kullanılmıştır. Daha sonrasında ise projeye WebAPI 'nin eklenmesiyle beraber operasyonların testi için Postman kullanılmaya başlanılmıştır. Bu katmanları yakından inceleyelim:


## Entities Layer

<b>Bu katman veritabanı nesneleri için oluşturulmuştur. Concrete klasöründe sadace tablolar için oluştrulmuş 'Class'lar bulunurken DTOs klasör kısmında ise farklı tablolardaki özellikleri birleştirmek amacıyla oluşturulan 'Class'lara yer verilmiştir. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Entities/Concrete">Concrete</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/Car.cs">Car.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/Color.cs">Color.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/Brand.cs">Brands.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/Customer.cs">Customer.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/Rental.cs">Rental.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/Concrete/User.cs">User.cs</a><br>
				</ul>
			</li>
			<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Entities/DTOs">DTOs</a>
				<ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs">CarDetailDto.cs</a>
				</ul>
			
</ul>		
                 
	


## Data Access Layer

<b> Veritabanı ile ilgili gerçekleşen operasyonlar ve veritabanı bağlantıları bu katmanda yer almaktadır. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11</code>)<br>
					</ul>
					</ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Abstract"> Abstract</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs">IBrandDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs">ICarDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs">IColorDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs">ICustomerDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs">IRentDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs">IUserDal.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Concrete"> Concrete</a>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Concrete/Ef">Entitiy Framework</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/CarsContext.cs">CarsContext.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfBrandDal.cs">EfBrandDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCarDal.cs">EfCarDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfColorDal.cs">EfColorDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCustomerDal.cs">EfCustomerDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfCarDal.cs">EfCarDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfRentalDal.cs">EfRentalDal.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/Ef/EfUserDal.cs">EfUserDal.cs</a><br>
</ul>
</ul>           
				<ul type="circle">
					<td>&#128206;<ins>InMemory klasörü içindekiler veritabanıyla bir bağlantısı olmayıp sadace başlangıç için test amacıyla oluşturulmuştur.</ins> <br>
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Concrete/InMemory">In Memory</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryDal.cs">InMemory.cs</a><br>
	
</ul>
</ul>

 </ul>	

## Business Layer

<b> DataAcess katmanında yer alan operasyonlara ait iş kuralları bu katmanda yer almıştır. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Abstract"> Abstract</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs">IBrandService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/ICarService.cs">ICarService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/IColorService.cs">IColorService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/ICustomerService.cs">ICustomerService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/IRentalService.cs">IRentalService.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Abstract/IUserService.cs">IUserService.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Concrete"> Concrete</a>
             <ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/BrandManager.cs">BrandManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/CarManager.cs">CarManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/ColorManager.cs">ColorManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs">CustomerManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/RentalManager.cs">RentalManager.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Concrete/UserManager.cs">UserManager.cs</a><br>
</ul>
</ul>
				<ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Constants">Constans</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Constants/Messages.cs">Messages.cs</a><br>
	
</ul>
</ul>
</ul>	

## Core Layer
<b>Core katmanı operasyonların generic yapılarla genelleştirildiği, her proje için kullanılabilecek potansiyele sahip bir katmandır. CRUD operasyonları bu katmanla beraber sadace IEntity interface'ne bağımlı olan nesneler için genelleştirilmiştir. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11</code>)<br>
					</ul>
					</ul>
	
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/DataAccess">Data Access</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/DataAccess/EntitiyFramework">Entity Framework</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/DataAccess/EntitiyFramework/EfEntityRepositoryBase.cs">EfEntityRepositoryBase.cs</a><br>
					</ul>
			</li>
			<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/DataAccess/IEntityRepository.cs">IEntitiyRepository.cs</a>
				</ul>
				
</ul>	
	
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Entities">Entities</a>
                                <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/IDto.cs">IDTO</a><br>
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/IEntity.cs">IEntity</a><br>
                                   
		
</ul>
				
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities">Utilities</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Results">Results</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/DataResult.cs">DataResult.cs</a><br>
						 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs">ErrorDataResult.cs</a><br>
							 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/ErrorResult.cs">ErrorResult.cs</a><br>
						  <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/IDataResult.cs">IDataResult.cs</a><br>
						<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/IResult.cs">IResult.cs</a><br>	  
							<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/Result.cs">Result.cs</a><br>
								<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs">SuccessDataResult.cs</a><br>
							<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Results/SuccessResult.cs">SuccessResult.cs</a><br>
						
							
</ul>
</ul>
				
</ul>
				
## WebAPI 

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/WebAPI/Controllers"> Controllers</a>
                                <ul type="circle">
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/BrandsController.cs">IBrandsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/CarsController.cs">CarsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/ColorsController.cs">ColorsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/CustomersController.cs">CustomersController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/RentalsController.cs">RentalsController.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Controllers/UsersController.cs">UsersController.cs</a><br>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#x1F4C4; </tr><a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Program.cs"> Program.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Startup.cs">Startup.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/WeatherForecast.cs">WeatherForecast.cs</a><br>
				
</ul>
			
	
</ul>


![](test.png)

## ConsoleUI

<b>Yazılan operasyonların kontrolü için bu katman kullanılmıştır. Bu katmanda test edilen operasyonlara <td>&#128279;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/ConsoleUI/Program.cs">buradan</a> ulaşabilirsiniz. Alt kısımda örnek olarak bazı operasyonların sonuçlarını görmektesiniz.
	
![](CarDetail.png)
	
![](Rental.png)	

![](RentalError.png)		

![](Postman.png)
##

<b>Projeye WebAPI katmanının eklenmesiyle beraber ConsoleUI katmanı yeterli olmadığı için test aracı olarak Postman kullanılmaya başlanılmıştır. Alt kısımda örnek olarak bazı operasyonlara ait test sonuçlarını görmektesiniz.

![](getcardetails.png)
<br>
<br>
<br>
![](rentalserror.png)
<br>
<br>
<br>
![](rentalsupdate.png)
<br>
<br>
<br>
![](rentalssuccess.png)


### <td>&#128206;<b>Writer
	
	Hilal Baştan
	
