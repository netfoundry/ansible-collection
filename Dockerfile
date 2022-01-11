# builds netfoundry/ansible
FROM netfoundry/python:latest
ARG collection_version="*"
RUN apt-get -y update
RUN apt-get -y install --no-install-recommends jq build-essential
RUN pip install ansible yq
RUN ansible-galaxy collection install --collections-path /usr/share/ansible/collections "netfoundry.platform:${collection_version}"
CMD ["bash"]
