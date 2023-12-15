# Backend for React Authentication App

This backend is the foundation of a React authentication app, providing APIs for user registration and login. The backend is developed with ASP.Net Core 6, utilizing Entity Framework for efficient model and database context creation. Docker is employed for containerization, and the Docker image is available on DockerHub for seamless deployment. The backend is hosted on an AWS EC2 instance.

## Technologies Used

- **ASP.Net Core 6:**
  - The backend API is built using ASP.Net Core 6 for a robust and scalable RESTful experience.

- **Entity Framework:**
  - Entity Framework is utilized to streamline the creation of models and the database context in the backend.

- **NuGet Packages:**
  - `Microsoft.EntityFrameworkCore.Tools:` Used for generating migrations, facilitating model updates to the database.
  - `Npgsql.EntityFrameworkCore.PostgreSQL:` Enables connection to the PostgreSQL database within the Docker container.

## Docker Deployment

The backend is containerized using Docker, providing easy deployment and management. Besides, the containerized app is deploy in a EC2 instance of AWS.

![image](https://github.com/DaniBonica001/APIRest-WebForm/assets/72984897/3297015b-bda0-46e5-8f46-dd7ecaec6a3c)


![image](https://github.com/DaniBonica001/APIRest-WebForm/assets/72984897/c1479e7c-9a83-4328-a2de-5aee2b3e0a29)

## Connection to the EC2 instance
In this reposiroty you can find the key.pem file that is neccessary to connect to the virtual machine. You can donwload it and use to try the app.

1. Command to connect:
   ````bash
   ssh -i /path/key-pair-name.pem ec2-user@3.16.49.101
2. Execute docker-compose:
   ````bash
   cd compose
   docker-compose up -d

  ![image](https://github.com/DaniBonica001/APIRest-WebForm/assets/72984897/8e78c835-47a9-4cd0-9f63-acfc5457efc1)

## Evidence
### Register
![image](https://github.com/DaniBonica001/APIRest-WebForm/assets/72984897/819f0e6f-8974-419e-adbe-b7602dece6a7)
### Login
![image](https://github.com/DaniBonica001/APIRest-WebForm/assets/72984897/33e3e8eb-568d-409b-b2fd-c159a243748e)

