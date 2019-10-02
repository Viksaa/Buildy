# Buildy
This is a student project for the subject "Internet Technologies". The idea and inspiration for this project are founded on our interests in computer parts and building. Therefore,  we made a web application with the exact same purpose and we named it Buildy.
# Table of Contents  
- [General Information](#general-information)
- [Technologies](#technologies)
- [Set-Up](#set-up)
- [Used Resources and Literature](#used-resources-and-literature)

# General Information
Most of the people who are into computer bulidng want to make multiple mock builds before deciding which computer is worth buying. However, gathering information from multiple websites and combining them might prove tricky for some people. Thats where Buildy comes into play. Buildy is a web application with a self-sustained database that ensures that the users have the best possible experience while trying to make a computer build.

# Technologies
In order to make this web application we taught the best platform was Microsoft's [Visual Studio 2019](https://visualstudio.microsoft.com/vs/), and as a programming language we chose [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) because its the most supported and best optimized programing language for this platform. 
- Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs, as well as websites, web apps, web services and mobile apps. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code. 
- C# (pronounced C sharp) is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines. It was developed around 2000 by Microsoft within its .NET initiative and later approved as a standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2018). C# is one of the programming languages designed for the Common Language Infrastructure.

We used many scripts such as:
- [Bootstrap](https://getbootstrap.com/)
- [Jquery](https://jquery.com/)
- [JavaScript](https://www.javascript.com/)

And plugins:
- [Jquery Data Tables](https://datatables.net/)
- [Entity Framework](https://www.entityframeworktutorial.net/)

Our database is [MySQL](https://www.mysql.com/) and its written code-first.
# Set-Up
Setting up this project might be tricky for more inexperinced programers. Firstly we would want to create a folder localy and name it "Buildy". After we have finished this we open a terminal inside the folder and write:
```
git clone https://github.com/Viksaa/Buildy.git
```
You can find the repository on [this link](https://github.com/Viksaa/Buildy). After you have successfully cloned the project you start it by executing the "Buildy.sln" file. Firstly you would like to download all the depending packages , usually Visual Studio reminds the user. After the download is completed you open the Nu Get Package Manager Console from the tools tab and write the following comand:
```
update-database
```
This command creates a database localy and seeds it with the necesary information. After all this is done you are ready to use Buildy!

 # Used Resources and Literature
- All of the images are from [Pc Part Picker](https://pcpartpicker.com/)
- https://fontawesome.com/
- https://getbootstrap.com/docs/4.3/examples/
- https://www.freepik.com/
