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
 
