# Ansible Collection - netfoundry.platform

* [README](./netfoundry.platform/README.md)
* [User Guide](https://developer.netfoundry.io/guides/ansible)

## Examples

```bash
# run the included network_from_download playbook with Compose
docker-compose pull && \
  NETFOUNDRY_API_ACCOUNT=~/.netfoundry/credentials.json \
  NETFOUNDRY_DOWNLOADED_NETWORK=~/Downloads/downloaded_network.yml \
    docker-compose run network_from_download

# run a custom playbook with Compose
docker-compose pull && \
  NETFOUNDRY_API_ACCOUNT=~/.netfoundry/credentials.json \
  NETFOUNDRY_ANSIBLE_PLAYBOOK=~/Downloads/playbook.yml \
    docker-compose run run_playbook
```

```bash
# run the included network_from_download playbook with Docker
docker run \
  --rm \
  --volume ~/.netfoundry/credentials.json:/netfoundry/credentials.json \
  --volume ~/Downloads/downloaded_network.yml:/netfoundry/downloaded_network.yml \
  netfoundry/ansible:latest \
    ansible-playbook netfoundry.platform.network_from_download
```

```bash
# install the collection and run the included network_from_download playbook
ansible-galaxy collection install netfoundry.platform
ansible-playbook netfoundry.platform.network_from_download \
    -e netfoundry_credentials=~/.netfoundry/credentials.json \
    -e netfoundry_downloaded_network=~/Downloads/downloaded_network.yml
```
