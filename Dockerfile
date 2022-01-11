# builds netfoundry/ansible
FROM netfoundry/python:latest
ARG collection_version="*"
# fresh pax
RUN apt-get -y update
# useful for verifying the installed version of the collection
RUN apt-get -y install --no-install-recommends jq
# ansible/cryptography deps
RUN apt-get -y install --no-install-recommends build-essential libssl-dev libffi-dev python-dev
# jq for YAML
RUN pip install ansible yq
RUN ansible-galaxy collection install --collections-path /usr/share/ansible/collections "netfoundry.platform:==${collection_version}"
CMD ["bash"]
