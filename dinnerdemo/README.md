# Dinner for Dapr (.Net User Group Karlsruhe, 15.06.2023)
The sample application is based on my series of my article about Dapr in the magazine dotnetpro 2/2022 - 4/2022

Deployment to local kubernetes 
_______________________

1. Create a kubernetes cluster and connect your local docker installation to kubernetes
2. Init the cluster for dapr: dapr init -k
3. Go to directory deploy\components and deploy the dapr components with kubectl apply -f . 
4. Create docker containers for all services and adjust the image names in the yaml files
5. go to directory deploy and deploy the services with kubectl apply -f . 
6. kubectl port-forward service/dinner 4444:80
   Start frontend: http://localhost:4444 
7. Redirect für Zipkin: kubectl port-forward svc/zipkin 19411:9411
   http://localhost:19411/zipkin/ 



Deployment to Azure Kubernetes Services
_______________________

1. Create a kubernetes cluster and connect your local docker installation to kubernetes
2. Init the cluster for dapr: dapr init -k
3. Go to directory deploy\components and deploy the dapr components with kubectl apply -f .
4. Create docker containers for all services and adjust the image names in the yaml files and the authentication for the repo.
5. go to directory deploy and deploy the services with kubectl apply -f .



(c) 2023: BridgingIT GmbH
