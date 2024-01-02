# Exam Repository for group Dare Share Care #
- **Frederik Bilgrav Andersen**: cph-fa116@cphbusiness.dk

- **Janus Stivang Rasmussen**: cph-jr270@cphbusiness.dk

- **Julius Krüger Madsen**: cph-jm352@cphbusiness.dk

## Architecture
![Architecture Diagram](diagrams/architecture.png)

## BPMN Diagram
![BPMN Diagram](diagrams/create-order-bpmn.png)

## Legacy Domain Model
![Legacy Domain Model Diagram](diagrams/legacy-domain.png)

## Usecase Diagram
![Usecase Diagram](diagrams/usecase.png)

## Setup
### ```docker-compose -f docker-compose.yml up -d --build```



## Microservice Repositories ##

### API Gateway
[API Gateway](https://github.com/Dare-Share-Care/exam-gateway)  
handles the connection between the client and each microservice. It is made using the Ocelot framework for .NET

### Order Service
[Order Service](https://github.com/Dare-Share-Care/exam-orders)
handles creation and storage of orders made through the MTOGO platform.
![Order Service APIs](images/Orders.Web%20Swagger.png)  

[Restaurant Service](https://github.com/Dare-Share-Care/exam-restaurant)  

[Auth Service](https://github.com/Dare-Share-Care/exam-auth)  

[Feedback Service](https://github.com/Dare-Share-Care/exam-feedback)

[Delivery Service](https://github.com/Dare-Share-Care/exam-courier)

[Email Service](https://github.com/Dare-Share-Care/exam-emails)

[Notification Service](https://github.com/Dare-Share-Care/exam-notification)

