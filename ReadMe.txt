docker build --no-cache -t artifactory.bell.corp.bce.ca:5096/rpatektonproveconcept .

docker run -d -p 443:443 -p 6000:80 gregqiubell/rpatektonproveconcept:latest

docker run -it -p 443:443 -p 7000:5000 artifactory.bell.corp.bce.ca:5096/rpatektonproveconcept:latest

http://localhost:7000/api/proveconcept/status

https://localhost:44393/api/proveconcept/status

oc new-app --docker-image="artifactory.bell.corp.bce.ca:5000/rpatektonproveconcept:latest" --name=rpatektonproveconcept 

oc expose service/rpatektonproveconcept

oc delete all -l app=rpatektonproveconcept