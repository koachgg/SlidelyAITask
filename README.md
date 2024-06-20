# SlidelyAITask
In this project, we are extending that functionality to create a Windows Desktop App that replicates the features of Google Forms.

# FrontEnd Task :
Frontend Repository
This repository contains the frontend code for the Slidely AI Task. The frontend application is built with Visual Basic .NET Framework.

## Table of Contents
Installation
Running the Application
Installation
Before you can run the application, you need to set up the necessary environment. Follow these steps:

Clone the Repository:
```sh
git clone https://github.com/bhaveshj2611/Bhavesh-SlidelyAI-Frontend.git
cd frontend-repo
```
Open Project: Open the project in Visual Studio

Restore Dependencies: Visual Studio will automatically restore the required NuGet packages when you open the solution.

Running the Application
To start the application, follow these steps:

Build the Solution:

Go to the Build menu and select Build Solution.

Run the Application:

Press F5 or go to the Debug menu and select Start Debugging.

By default, the application will run locally on your machine.

# Express TypeScript Backend

## Description
This is a Node.js backend server built with Express and TypeScript. It provides endpoints to manage submissions, storing them in a JSON file.

## Setup Instructions
### Prerequisites
- Node.js (version 14.x or higher)
- npm (version 6.x or higher)

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/express-ts-backend.git

2.Navigate to the project directory:

```sh
npm run build
```

3. Install the dependencies:
```sh
npm install
```

Configuration
Ensure you have a db.json file in your project root. This file will serve as your database.
Building the Project

Compile the TypeScript code to JavaScript:
```sh
npm run build
```

Running the Server
Start the development server:
```sh
npm run dev
```

Endpoints
GET /ping
Description: Health check endpoint.
Response: true
POST /submit
Description: Submits new data.
Parameters: name, email, phone, github_link, stopwatch_time

Example :
```sh
curl -X POST http://localhost:3000/submit -H "Content-Type: application/json" -d '{"name":"John Doe","email":"john@example.com","phone":"1234567890","github_link":"https://github.com/johndoe","stopwatch_time":"00:05:23"}'
```
Database
The data is stored in a db.json file located in the project root directory. Ensure this file is present and writable.

Development Notes
Make sure to restart the server after making changes to the TypeScript files to see the updates.
Use the following command to compile TypeScript files without running the server:
```sh
npm run build
```


License
This project is licensed under the MIT License. See the LICENSE file for more details.
  

### Explanation:
- **Description**: Brief overview of the project.
- **Setup Instructions**: Detailed steps to clone the repository, navigate to the project directory, install dependencies, and build the project.
- **Configuration**: Instructions to ensure the `db.json` file is present.
- **Running the Server**: Command to start the development server and the URL where the server will be running.
- **Endpoints**: Detailed information on how to use the available endpoints with examples.
- **Database**: Information about the database file used for storing submissions.
- **Development Notes**: Additional notes for developers to ensure a smooth development process.
- **License**: Standard practice to include the license information.

This README provides all the necessary information to set up, run, and use the backend server, making it easy for anyone to get started with your project.

## This backend project is build as a task for Slidely AI - Internship by Belo Abhigyan
