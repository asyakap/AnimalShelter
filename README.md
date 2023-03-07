# Animal Shelter web app

##### By _Asia Kaplanyan_

#### _Description_

_A web application that allows user to add animals to an Animal Shelter._

## Technologies Used

* C#
* HTML
* Visual Studio
* Entity Framework Core

## Setup Instructions

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Shelter".
3. Within the production directory "Shelter", create a new file called appsettings.json.
4. Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
5. Within the production directory "Shelter", run dotnet watch run in the command line to start the project in development mode with a watcher.
6. Open the browser to https://localhost:5001. 

## Known Bugs

* no known bugs

## License

MIT

* Copyright (c) _2023_ _Asia Kaplanyan_

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


