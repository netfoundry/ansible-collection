# Ansible Collection - netfoundry.platform

* [README](./netfoundry.platform/README.md)
* [User Guide](https://developer.netfoundry.io/guides/ansible)

## Examples

```bash
# run the network_from_download playbook with Compose
docker-compose pull && \
  NETFOUNDRY_API_ACCOUNT=~/.netfoundry/credentials.json \
  NETFOUNDRY_DOWNLOADED_NETWORK=/tmp/MY_PLAYBOOK.yml \
    docker-compose run network_from_download
```

```bash
# run the network_from_download playbook with Docker
docker run \
  --rm \
  --volume ~/.netfoundry/credentials.json:/netfoundry/credentials.json \
  --volume /tmp/MY_PLAYBOOK.yml:/netfoundry/downloaded_network.yml \
  netfoundry/ansible:latest \
    ansible-playbook netfoundry.platform.network_from_download
```

```bash
# install the module, collection, and run the network_from_download playbook
ansible-galaxy collection install netfoundry.platform
ansible-playbook netfoundry.platform.network_from_download \
    -e netfoundry_credentials=~/.netfoundry/credentials.json \
    -e downloaded_network_file=/tmp/MY_PLAYBOOK.yml
```
