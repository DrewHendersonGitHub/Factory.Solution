# _Factory Manager_

### _By Drew Henderson_

#### _This website lets you track engineers and machines in a factory._

## Technologies Used

* _C#_
* _.NET_
* _cshtml_
* _Entity Framework_
* _MySQL_
* _css_
* _Bootstrap_

## Description

_This application uses a many-to-many database relationship to link engineers with the machines they can operate. You can add new engineers and machines, update them and link them with eachother._

## Setup/Installation Requirements

* _Download or clone ```https://github.com/DrewHendersonGitHub/HairSalon.Solution``` to your computer._
* _In a terminal inside directory ```Factory```, make a new file ```appsettings.json```._
* _Add the following code with ```{DATABASE}```, ```{USERNAME}```, and ```{PASSWORD}``` replaced with your choice._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};"
  }
}
```
* _Run `dotnet ef database update` inside the ```Factory``` directory to build your database._
* _Run ```dotnet restore``` and ```dotnet run``` in your terminal to build the project and open a local server._
* _CTRL click on the first listed URL, likely to be ```http://localhost:5000/```._

## Known Bugs

* _No known bugs at this time._

## License

[MIT](https://opensource.org/licenses/MIT)

_Copyright (c) 2022  Drew Henderson_