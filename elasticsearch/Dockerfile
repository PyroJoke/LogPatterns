FROM elasticsearch

RUN \
	cd /usr/share/elasticsearch \
	bin/plugin -i mobz/elasticsearch-head \
	bin/plugin -i elasticsearch/marvel/latest \
	service elasticsearch restart
