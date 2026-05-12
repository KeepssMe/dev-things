@echo off

cd ..
docker-compose --file docker-compose.local-dev.yaml --env-file .env up -d storage.mssql storage.mongodb storage.rabbitmq

pause