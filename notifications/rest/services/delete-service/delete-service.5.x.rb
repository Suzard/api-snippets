# NOTE: This example uses the next generation Twilio helper library - for more
# information on how to download and install this version, visit
# https://www.twilio.com/docs/libraries/ruby
require 'twilio-ruby'

# Get your Account Sid and Auth Token from twilio.com/user/account
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'

# set up a client to talk to the Twilio REST API
client = Twilio::REST::Client.new(account_sid, auth_token)

# Provide the SID for an existing service
service = client.notify.v1.services('ISxxx')

response = service.delete

puts response
