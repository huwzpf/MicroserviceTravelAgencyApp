#!/bin/bash

set -e
set -u

# Array of databases and corresponding users and passwords
declare -A db_users
db_users=( 
  ["userservice_db"]="user_userservice_db:password_userservice_db" 
  ["db2"]="user2:password2" 
  ["db3"]="user3:password3" 
)

function create_database() {
  local database=$1
  local user=$2
  local password=$3

  echo "Creating database '$database'"
  psql -v ON_ERROR_STOP=1 --username "$POSTGRES_USER" <<-EOSQL
    CREATE USER $user WITH ENCRYPTED PASSWORD '$password';
    CREATE DATABASE $database OWNER = $user;
EOSQL
}

# Iterate over the databases and create each one with its user
for db in "${!db_users[@]}"; do
  user=$(echo ${db_users[$db]} | cut -d':' -f1)
  password=$(echo ${db_users[$db]} | cut -d':' -f2)
  create_database $db $user $password
done