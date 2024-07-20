# TimerTrigger for AKS using Keda- C<span>#</span>

This is a fully functional example of how to create the simplest timer based azure function and deploy it to AKS using a keda scaledobject configuration.

# Prerequisites

You will need an Azure Account for the Azure Storage requirement.  This is configured in the aks-config.yaml file under the Containers > env section.

You will need a container registry account.  In this example, I am using Dockerhub.  

You will need to build your dockerfile and deploy it to your container registry.

Example:
```
docker build -t slmcmahon/demo-func:v3 .
docker push slmcmahon/demo-func:v3
```

You should have access to a kubernetes cluster.  For my examples, I have simply enabled the single-node kubernetes cluster that can be created with Docker Desktop