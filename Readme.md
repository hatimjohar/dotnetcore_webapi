How to Create Web API in .Net Core
===================

Description
----
This article is prepared to describe the implementation details regarding developing a webapi in ASP.NET Core. 
Prerequisites required
-----------
	

>  1. Windows machine for development (Win 7 or higher version of windows)
>  2. .Net Core SDK - Get it from [here](https://www.microsoft.com/net/download/windows) 	 
>  3. Postman tool to test the webapi - get the chrome extension from [here](https://chrome.google.com/webstore/detail/postman/fhbjgbiflinjbdggehcddcbncdddomop?hl=en)

Steps
---

*  Open Visual Studio (2015/2017) as an Administrator on your development machine. From File > New Project
  select **.Net Core** from Project type under **Visual C#** and then select **ASP.NET core web application** project, give it a name and click on **OK** button to create the project
  
*  Select **Webapi** and click on **Ok** button
Once the project is created, you will observe a default controller with the name **Values** will be created inside **Controllers** folder, if you want you can create a new controller by right clicking on Controllers folder > Controller > Add and give the name of the controller. For demonstration purpose I will use **Values** controller
 
*  Open the **ValuesController.cs** file and change the attribute 

	
	```c#
    [Route("api/[controller]")]
    to
    [Route("GetData")]
    ```
    
	the reason why we changed the route attribute is because we do not want our webapi to be accessed with the path /api/&lt;controler> instead we want it to be accessed with **/GetData**

*  Now replace the entire ValuesController class code with this code
 
  
```c#
    [Route("GetData")]
    public class ValuesController : Controller
    {
        // Get GetData/GetHelloWorld
        [HttpGet]
        public string GetHelloWorld()
        {
            return "Hello World";
        }

        // Get GetData/
        [HttpGet("{key}")]
        public string GetQuery(string key)
        {
            // statements to  process the supplied keys
            return "Key: " + key  ; 
        }
        
    }
```
 

 

*  In the Project, you will find a node named as **Properties** expand it and edit the file **launchSettings.json**
 here update the value of **launchUrl** from api/Values to GetData
 After updating, your file should look like this

```json
    "profiles": {
        "IIS Express": {
          "commandName": "IISExpress",
          "launchBrowser": true,
          "launchUrl": "GetData",
          "environmentVariables": {
            "ASPNETCORE_ENVIRONMENT": "Development"
          }
        },
        "MyFirstWebAPI": {
          "commandName": "Project",
          "launchBrowser": true,
          "launchUrl": "GetData",
          "environmentVariables": {
            "ASPNETCORE_ENVIRONMENT": "Development"
          },
```
*  Save the changes you made in your project and now execute the project. You should be able to the see the output as **Hello World** in your browser window

> Ex: Url in browser : http://localhost:61979/GetData   {port number can
> be different in your case}
> 
> Output - Hello World

Similarly, you can get data based on your URI format, here in the second action method i.e. GetQuery I have determined an URI format **GetData/{key}** in the HttpGet attribute. when our webapi url is generated in this fashion GetQuery action method will be executed

> to execute GetQuery action,  url in the browser -
> http://localhost:61979/GetData/1234 

> Output - Key: 1234

*  Alternatively you can use Postman tool to execute the REST endpoint and get the response

*  You can design your own URI template in the HttpGet attribute. 

Conclusion
---
We have learned how we can create a webapi in .Net Core application and how to set the URI path. The service we developed is the rest based service and returns JSON data as the output. If you have a WCF service by going through this article you can create a new webapi and start converting it into webapi. Conversion will require to create appropriate actions and set URI formats as mentioned in this article