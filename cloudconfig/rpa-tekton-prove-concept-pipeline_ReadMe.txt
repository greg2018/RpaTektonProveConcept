#01) Instruction of pipeline, task and resources for try out
oc create -f 01.rpa-tekton-prove-concept-pvc.yml
oc create -f 02.rpa-tekton-prove-concept-pipeline.yml
oc create -f 06.rpa-tekton-prove-concept-pipeline-run.yml

oc apply -f 07.show-readme-task.yaml

oc apply -f 02.rpa-tekton-prove-concept-pipeline.yml

oc create -f 06.rpa-tekton-prove-concept-pipeline-run.yml

tkn task ls

tkn clustertasks ls

tkn pipeline ls

tkn pipelinerun list

tkn pipeline logs -f
  
#02) Instructions for docker and git repository

oc create secret docker-registry docker-io-secret --docker-server=docker.io --docker-username=gregqiu --docker-password=Sap12#net --docker-email=gregqiu819@hotmail.com

oc secrets link pipeline docker-io-secret

oc apply -f pipeline-github-pat-secret.yaml

oc secrets link pipeline pipeline-github-pat-secret	


oc describe sa pipeline

oc get sa -n pipelines-tutorial pipeline -o yaml

oc get secret pipeline-github-pat-secret -o yaml

#03) Other instructions for reference
	
oc secrets link default docker --for=pull

docker.io

docker pull docker.io/gregqiu/spring-boot-example:latest

oc create secret docker-registry dev-docker-artifactory-secret --docker-server=artifactory.bell.corp.bce.ca:5095 --docker-username=fidappBBM_ARA_DEV --docker-password='+2]5\!jYTHhk+Ei4' --docker-email=fidappBBM_ARA_DEV@bell.corp.bce.ca

oc create secret docker-registry dev-docker-artifactory-secret-port5001 --docker-server=artifactory.bell.corp.bce.ca:5001 --docker-username=eq03590 --docker-password=Camunda#715 --docker-email=greg.qiu@bell.corp.bce.ca


oc create secret generic pipeline-github-pat-secret \
    --type=kubernetes.io/basic-auth \
    --from-literal=username=greg2018 \
    --from-literal=password=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
	

https://console-openshift-console.apps-crc.testing

The server is accessible via web console at:
  https://console-openshift-console.apps-crc.testing

Log in as administrator:
  Username: kubeadmin
  Password: oaTdd-gBFB6-nkvCY-G2fye

Log in as user:
  Username: developer
  Password: developer

Use the 'oc' command line interface:
  > @FOR /f "tokens=*" %i IN ('crc oc-env') DO @call %i
  > oc login -u developer https://api.crc.testing:6443
  
	

 
