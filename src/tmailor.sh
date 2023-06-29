#!/bin/bash

api="https://tmailor.com"
graph_api="https://s992000-graph.tmailor.com"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function generate_email() {
	curl --request POST \
		--url "$api/wtf" \
		--user-agent "$user_agent" \
		--header "content-type: application/x-www-form-urlencoded" \
		--data "type=newemail"
}

function get_inbox() {
	# 1 - email: (string): <email>
	# 2 - token: (string): <token>
	curl --request POST \
		--url "$graph_api/email/check" \
		--user-agent "$user_agent" \
		--header "content-type: application/x-www-form-urlencoded" \
		--data "email=$1&token=$2&m=1"
}
