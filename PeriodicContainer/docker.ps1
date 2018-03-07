dotnet clean PeriodicContainer.csproj
dotnet publish PeriodicContainer.csproj
docker rmi periodicapp
docker build --no-cache -t periodicapp .
docker tag periodicapp  r.cfcr.io/raducrisan/periodicapp
docker push r.cfcr.io/raducrisan/periodicapp
kubectl create secret docker-registry cfcrioregcred \
    --docker-server=r.cfcr.io --docker-username= \
    --docker-password= \
    --docker-email=
kubectl apply -f kubernetes.yaml