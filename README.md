# RaffleTicketProject2


## Ticket & Prize Generator System - SFIA 2 

Project Contributor: Tehmina Ahmed 

Copyright (c) 2021 RaffleRiff


## Abstract
The KaspasTill App was planned, designed and has been documented in this ReadMe.MD to show the process of the project. Agile Methodology was used throughout the project to ensure efficiency where possible. It's a Responsive till system App using CRUD functionality. Allowing users to Create an item, View the item, update it and delete it if need be. 
Kaspas LTD is an ice cream parlour that provides the user with the ability to create a dessert of choice and enter it into the MySQL database. The option for the user is to be able to Create a Dessert and a Topping (as their product of choice), to view it, update it and/ delete it based on their liking of the product. The idea behind this App is to give the user control of their products - essentially replicating the purpose of a self service till. This idea stems from a theory of customer journey where it is beleived that in modern times, the customer should be given more control of their product journey in order to ensure higher rates of satisfaction. This theory has been applied to the Till app to assess this hypothesis. 



## Aims & Objectives 
  Aims                                                    | Objectives                                                                     |
| :----------------------------------------------------:  | :------------------------------------------------------------------------------:
| 1) Create a solution                                    | a) Curate an idea that solves an issue                                          |
| 2) Design a Full Stack App using 4 services             | b) Create a High Fidelity ProtoType/Wireframe with Lucid                        |
| 3) Setup Agile Methodology software                     | c) Create Asana board, Jira, GitHub and set time goals                          |
| 4) Implement App using CRUD Functionality               | d) Use Technologies listed below to implement App                               |
| 5) Test App using UNIT testing                          | e) Use Automation testing and test each feature of the App against requirements |
| 6) Use CI & CD to ensure efficient version control      | f) Use GitHub and Visual Studio to continously integrate and deploy App edits   |
| 7) Deploy App                                           | g) Deploy App using GitHub actions and Terraform                                |



## Technologies & Methodologies Used
* Project Management: Agile methodology, Kanban - Asana, Jira, GitHub 
* C#
* HTML
* CSS
* ASP.NET
* Git
* Continous Integration
* Azure Portal/CLI
* Terraform 
* LucidSpark
* Jira

## Essential Features 
### Agile Methodology 
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Trello%20Board.png">
</p>
Here is the Asana Kanban Board used to track tasks against time and the priority order of them. The Board displays tasks that were ordered into...
To-Do,
 In Progress, and, 
 Done 
This was helpful and was used as an online diary for me to keep track of my tasks. 

## Requirements - using Moscow Prioritisation
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/MoSCoW%20prioritization.png">
</p>
This technique allowed me to see which requirements would be essential to implement VS. requirements which would be a stretch goal. 

## Initial Documentation (before idea modification)

### Jira Backlog 
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Jira%20Board.png">
</p>
Above is the Backlog for the previously intended MVP (minimum viable product) which was the initial plan. The App was initially designed to allows customers to create an order by appending one or more products to their order. However due to time constraints, this idea had to be modified to realistically meet the deadline. And so, the idea and database tables was simplified so that the user creates their own idea of a dessert with a topping. 


### Design - Wireframes 



Home Page                                                                                                           |  Order Page
:-----------------------------------------------------------------------------------------------------------------: |:-------------------------:
![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Kaspas%20App%20HF%20ProtoType.png)  | ![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/HF%20ProtoType%20Order%20page.png) |

These ProtoTypes were designed on paper first as initial designs and were then digitally created using LucidSpark. This was done to create a visual guide as to how the App should look - however it was understood that this would be a stretch goal and the aesthetics of the app were to only be focused on once the CRUD functionality and other requirements had been implemented successfully

### User Stories 

Place Order                                                                                                         |  Delete Order
:-----------------------------------------------------------------------------------------------------------------: |:-------------------------:
![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/User%20Story%20Delete%20Order.png)  | ![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/User%20Story%20Place%20Order.png) |

The user stories display the scenario of how the App interacts with the user indirectly, using a frontend to display the randomly generated results and 3 webApi's running in the background. 


## Updated Documentation (After idea modification)


### Risk Assessment 
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/RA%201.png">
</p>
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/ra%202.png">
</p>
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/ra%203.png">
</p>
<p align="center">
  <img width="750" height="475" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/RA%204.png">
</p>


## Report 
What I did well                                                                                                     |  How could I improve?
:-----------------------------------------------------------------------------------------------------------------: |:--------------------------------------------:
| 1) I successfully designed my App using wireframes                                                                | a) I could have created my stretch goal databases
| 2) I used Agile methodology throughout the project to manage tasks and time                                       | b) could have used CSS/BootStrap to make App prettier
| 3) I successfully created my MVP database tables using C# and MySQL                                               | c) Could have integrated more JavaScript
| 4) I successfully connected to Azure services and MySQL workbench 8.0                                             | d) Could have done more CI using GitHub if it connected
| 5) I successfully used HTML, CSS & C# with ASP.NET to create an MVC App with CRUD functionality                   | e) Could have implemented Testing by fixing bugs
| 6) I was able to identify and find solutions to risks associated with development in the matrix                   | f) Could have used Angular as part of front end
| 7) I tried to deploy the App to a satisfactory requirement level however VS Studio kept crashing (see below)      | g) Deploy via Azure Pipelines & DevOps & fix bugs


<p align="center">
  <img width="750" height="475" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Deployment%20bugs.png">
</p>




## Developer
Tehmina Ahmed
