Analyze_RpaTektonProveConcept: sqp_5437300465258479604903fb77f83ee06e30320d

dotnet tool install --global dotnet-sonarscanner

dotnet sonarscanner begin /k:"RpaTektonProveConcept" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="sqp_5437300465258479604903fb77f83ee06e30320d"

dotnet build

dotnet sonarscanner end /d:sonar.login="sqp_5437300465258479604903fb77f83ee06e30320d"