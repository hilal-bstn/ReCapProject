# ReCapProject(Back-End)



![](https://user-images.githubusercontent.com/77468985/108639180-479f1a80-74a4-11eb-9e9b-8bd51907e836.png) 
#

<b>ReCapProject, SOLID prensiplerine bağlı kalınarak ve N-Katmalı mimari yapısıyla C# programlama diline ait bir araç kiralama projesidir. Şu anda projenin back-end kısmını incelemektesiniz.<br> 
<td>&#128206;<ins><b>Projenin frontend kısmına <a href="https://github.com/hilal-bstn/ReCapProject-Frontend/blob/master/README.md">buradan</a> ulaşabilirsiniz.</ins>
	
![](https://user-images.githubusercontent.com/77468985/108639775-4e7b5c80-74a7-11eb-91bc-2f1419e179db.png)

#
 
<b>Veritabanı, Visual Studio 2019 içindeki SQL Server Object Explorer kısmından yola çıkılarak oluşturulmuştur. Alt kısımda bu veritabanına ait tabloların alan isimlerini ve veri tiplerini görebilirsiniz.  

![](https://user-images.githubusercontent.com/77468985/113464069-b9b73780-9432-11eb-997d-82bd02a6f13d.png)
![](https://user-images.githubusercontent.com/77468985/109575681-5ff5e180-7b03-11eb-8475-a8626ff76d5f.png)
![](https://user-images.githubusercontent.com/77468985/109575965-ed393600-7b03-11eb-8afa-aa04b858caf8.png)
![](https://user-images.githubusercontent.com/77468985/113491234-ea04e180-94d7-11eb-841d-5594db715a72.png)





![](https://user-images.githubusercontent.com/77468985/108639850-bcc01f00-74a7-11eb-99b8-21673b26989a.png) 

#

<b>ReCapProject; Entities, DataAccess ve Business katmanlarından oluşmaktadır. Başlangıç olarak bu katmanlardaki operasyonların simülasyonu için ConsoleUI katmanı kullanılmıştır. Daha sonrasında ise projeye WebAPI 'nin eklenmesiyle beraber operasyonların testi için Postman kullanılmaya başlanılmıştır. Bu katmanları yakından inceleyelim:


## Entities Layer

<b>Bu katman veritabanı nesneleri için oluşturulmuştur. Concrete klasöründe sadace tablolar için oluştrulmuş 'Class'lar bulunurken DTOs klasör kısmında ise farklı tablolardaki özellikleri birleştirmek amacıyla oluşturulan 'Class'lara yer verilmiştir. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Entities/Concrete">Concrete</a><br/>
                      <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Entities/DTOs">DTOs</a><br>
		      <td>&#x1F4C4; </tr><a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Entities/PasswordUpdate.cs">PasswordUpdate.cs</a>
			
</ul>		
                 
	


## Data Access Layer

<b> Veritabanı ile ilgili gerçekleşen operasyonlar ve veritabanı bağlantıları bu katmanda yer almaktadır. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)</code><br>
					</ul>
					</ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Abstract"> Abstract</a>
                                
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Concrete"> Concrete</a>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/DataAccess/Concrete/Ef">Entitiy Framework</a><br>
					
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
   
   <ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Autofac(v6.1.0)</code><br>
					<td>&#128205;<t> <code>Autofac.Extras.DynamicProxy(v6.0.0)</code><br>
					<td>&#128205;<t> <code>FluentValidation(v9.5.1)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http(v2.2.2)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Abstractions(v2.2.0)</code><br>
					<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Features(v5.0.3)</code><br>
					<td>&#128205;<t> <code>Microsoft.Extensions.DependencyInjection(v5.0.1)</code><br>
					</ul>
					</ul>

<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Abstract"> Abstract</a>
                                
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/BusinessAspects"> Business Aspect</a>
             <ul>
		                <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/BusinessAspects/Autofac">Autofac</a><br>
				
</ul>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Concrete"> Concrete</a>
             
</ul>
				<ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/Constants">Constans</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/Constants/Messages.cs">Messages.cs</a><br>
	
</ul>
</ul>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/DependencyResolvers">Dependency Resolvers</a><br>
					<ul>
				<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/DependencyResolvers/Autofac">Autofac</a><br>
					<ul>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs">AutofacBusinessModule.cs</a><br>
				
</ul>
					
			
</ul>
</ul>
                                <ul type="circle">
					<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/ValidationRules">Validation Rules</a><br>
					<ul>
				<td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Business/ValidationRules/FluentValidation">Fluent Validation</a><br>
					
					
			
</ul>

</ul>	

## Core Layer
<b>Core katmanı operasyonların generic yapılarla genelleştirildiği, her proje için kullanılabilecek potansiyele sahip bir katmandır.<br><br>	
	&#9989;Bellek yönetimi(Caching)<br>
	&#9989;Operasyonların performans kontrolü(Performance)<br>
	&#9989;Bir grup operasyonun sırayla, sağlıklı bir şekilde çalışması için transaction yönetimi<br>
	&#9989;CRUD operasyonlarının sadace IEntity interface'ne bağımlı olan nesneler için genelleştirilmesi  <br>
	&#9989;Genel bağımlılık zincirleri oluşturulması (Bu zincirlerin oluşumunda <em>Autofac</em> ten yararlanılmıştır.) <br>
	&#9989;CUD(IResult) ve R(IDataResult) operasyonları için ayrı ayrı error ve success yönetimi yapılması <br><br>
	
 Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.<br>
<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
					<td>&#128205;<t> <code>Autofac(v6.1.0)</code><br>	
						<td>&#128205;<t> <code>Autofac.Extras.DynamicProxy(v6.0.0)</code><br>
					<td>&#128205;<t> <code>FluentValidation(v9.5.1)</code><br>
						<td>&#128205;<t> <code>Microsoft.AspNetCore.Http(v2.2.2)</code><br>
				<td>&#128205;<t> <code>Microsoft.AspNetCore.Http.Features(v5.0.3)</code><br>
				<td>&#128205;<t> <code>Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)</code><br>
				<td>&#128205;<t> <code>Microsoft.IdentityModel.Tokens(v6.8.0)</code><br>
				<td>&#128205;<t> <code>System.IdentityModel.Tokens.Jwt(v6.8.0)</code><br>
				
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects">Aspects</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects/Autofac">Autofac</a><br>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects/Autofac/Caching">Caching</a><br>	 	 
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs">CacheAspect.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs">CacheRemoveAspect.cs</a><br>
				
</ul>	
</ul>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects/Autofac/Performance">Performance</a><br>	 	 
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs">PerformanceAspect.cs</a><br>
				
</ul>	
</ul>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects/Autofac/Transaction">Transaction</a><br>		 
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs">TransactionScopeAspect.cs</a><br>
				
</ul>	
</ul>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Aspects/Autofac/Validation">Validation</a><br>	 
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs">ValidationAspect.cs</a><br>
				
</ul>	
</ul>
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/CrossCuttingConcerns">Cross Cutting Concerns</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/CrossCuttingConcerns/Caching">Caching</a><br>
					<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/CrossCuttingConcerns/Caching/Microsoft">Microsoft</a><br><ul type="circle">
<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs">MemoryCacheManager.cs</a><br>
					</ul>
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/CrossCuttingConcerns/Caching/ICacheManager.cs">ICacheManager.cs</a><br>
					</ul>
					 </ul>
				<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/CrossCuttingConcerns/Validation">Validation</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs">ValidationTool.cs</a><br>
					</ul>
						 </ul></ul>

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
	<ul type="circle">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/DependencyResolvers">Dependency Resolvers</a>
                                <ul type="circle">
			                 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/DependencyResolvers/CoreModule.cs">CoreModule.cs</a><br>
		
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Entities">Entities</a>
	     <ul type="circle">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Entities/Concrete">Concrete</a>   <td>&#128205;<t>Login, register işlemleri ve bir kullacıya atanan roller genel olarak her projede olmasından dolayı bu işlemlere ait nesneler Core katmanın da oluşturulmutur.<br>
                                <ul type="circle">
                                  <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/Concrete/OperationClaim.cs">OperationClaim.cs</a><br>
		                   <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/Concrete/User.cs">User.cs</a><br>
                                   <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/Concrete/UserOperationClaim.cs">UserOperationClaim.cs</a><br>
		
</ul>
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/IDto.cs">IDTO</a><br>
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Entities/IEntity.cs">IEntity</a><br>
                                   
		
</ul>
				
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Extensions">Extensions</a>
                                <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ClaimExtensions.cs">ClaimExtensions.cs</a><br>
					<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs">ClaimsPrincipalExtensions.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ErrorDetails.cs">ErrorDetails.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ExceptionMiddleware.cs">ExceptionMiddleware.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ExceptionMiddlewareExtensions.cs">ExceptionMiddlewareExtensions.cs</a><br>
						<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Extensions/ServiceCollectionExtensions.cs">ServiceCollectionExtensions.cs</a><br>
				</ul>
				
</ul>	
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities">Utilities</a><br>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Business">Business</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Business/BusinessRules.cs">BusinessRules.cs</a> <td>&#128205;İş kurallarının genel bir yapıdan geçmesi sağlanılmıştır.<br>
						
				
					
</ul>
</ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/FileHelper">FileHelper</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/FileHelper/FileHelper.cs">FileHelper.cs</a><td>&#128205;Dosya işlemleri CRUD operasyonları için genel hale getirilmiştir.<br><br>
</ul>
</ul>
<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/IOC">IOC</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/IOC/ServiceTool.cs">ServiceTool.cs</a><br>
				       <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/IOC/ICoreModule.cs">ICoreModule.cs</a><br>
</ul>
</ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Interceptors">Interceptors</a><br>
						 <ul type="circle">
					 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs">AspectInterceptorSelector.cs</a><br>
						 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs">MethodInterception.cs</a><br>
							 <td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs">MethodInterceptionBaseAttribute.cs</a><br><br>
						  
						
						
							
</ul>
</ul>
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
	<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Security">Security</a>
                                <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Security/Encryption">Encryption</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs">SecurityKeyHelper.cs</a><br>
			<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs">SigningCredentialsHelper.cs</a><br>
					</ul>
						 </ul>
	 <ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Security/Hashing">Hashing</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs">HashingHelper.cs</a><br>
					</ul>
						 </ul>
	<ul type="circle">
					 <td>&#128194;<a href="https://github.com/hilal-bstn/ReCapProject/tree/master/Core/Utilities/Security/JWT">JWT</a><br>
				<ul type="circle">	 
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/JWT/AccessToken.cs">AccessToken.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs">ITokenHelper.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs">JWTHelper.cs</a><br>
		<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs">TokenOptions.cs</a><br>
					</ul>
						 </ul>
	
</ul>
			
</ul>
				
## WebAPI 

<ul type="circle">
					<td>&#128230;<ins><b>NuGet Packages</b></ins><br>
					<ul>
				<td>&#128205;<t> <code>Autofac.Extensions.DependencyInjection(v7.1.0)</code><br>
				<td>&#128205;<t> <code>Microsoft.AspNetCore.Authentication.JwtBearer(v3.1.12)</code><br>
				
</ul>
</ul>
<ul type="disc">
	<tr>
        <td>&#128194; </tr><a href="https://github.com/hilal-bstn/ReCapProject/tree/master/WebAPI/Controllers"> Controllers</a>
                                
</ul>
<ul type="disc">
	<tr>
        <td>&#x1F4C4; </tr><a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Program.cs"> Program.cs</a><br>
				<td>&#x1F4C4;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/WebAPI/Startup.cs">Startup.cs</a><br>
				
				
</ul>
			
	
</ul>


![](https://user-images.githubusercontent.com/77468985/108639915-13c5f400-74a8-11eb-8bf3-28ac80e569ee.png)

## ConsoleUI

<b>Yazılan operasyonların kontrolü için bu katman kullanılmıştır. Bu katmanda test edilen operasyonlara <td>&#128279;<a href="https://github.com/hilal-bstn/ReCapProject/blob/master/ConsoleUI/Program.cs">buradan</a> ulaşabilirsiniz. Alt kısımda örnek olarak bazı operasyonların sonuçlarını görmektesiniz.
	
![](https://user-images.githubusercontent.com/77468985/108639973-525bae80-74a8-11eb-91e3-240005af63cc.png)
	
![](https://user-images.githubusercontent.com/77468985/108640042-9c449480-74a8-11eb-8995-7a9576bd1502.png)	

![](https://user-images.githubusercontent.com/77468985/108640122-f2193c80-74a8-11eb-846a-bade942d39a0.png)

![](https://user-images.githubusercontent.com/77468985/108639532-10316d80-74a6-11eb-8686-ac8dc1a716d9.png)
##

<b>Projeye WebAPI nin eklenmesiyle beraber ConsoleUI katmanı yeterli olmadığı için test aracı olarak Postman kullanılmaya başlanılmıştır. Alt kısımda örnek olarak bazı operasyonlara ait test sonuçlarını görmektesiniz.<br>
<br>
<b><em>-<ins>Cars<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640191-46bcb780-74a9-11eb-83d7-a3037cb2ef6d.png)
<br>
<br>
<br>
<b><em>-<ins>Rental<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640225-84214500-74a9-11eb-93b2-70635c7b1253.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/108640252-969b7e80-74a9-11eb-90dc-f10667fc4e59.png)

<br>
<br>
<br>

![](https://user-images.githubusercontent.com/77468985/108640276-c21e6900-74a9-11eb-9bda-0a937d14ba9a.png)
<br>
<br>
<br>
<b><em>-<ins>User<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572822-f1af2000-7afe-11eb-8f46-799d590ec9c8.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572859-055a8680-7aff-11eb-96d8-7bad598e3805.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572923-1e633780-7aff-11eb-9c43-c6c7e7e30c4e.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109572993-3b980600-7aff-11eb-853e-7190a66dd2f0.png)
<br>
<br>
<br>
<b><em>-<ins>CarImages<br></ins>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109799733-6c765900-7c2d-11eb-9552-8fa85c6b8895.png)
<br>
<br>
<br>	
![deneme5](https://user-images.githubusercontent.com/77468985/110037893-16e69d00-7d50-11eb-864e-43ed7aefcd98.png)
<br>
<br>
<br>
![](https://user-images.githubusercontent.com/77468985/109800163-ead2fb00-7c2d-11eb-94d0-64e3e0997f48.png)
<br>


	
