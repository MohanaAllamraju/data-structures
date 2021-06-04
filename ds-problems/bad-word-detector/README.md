# Find a bad word in a given user name

## Problem

### An input string will be given along with list of badwords. we are looking for a optimized solution to identify bad words.

- A bad word could be anywhere in the user name
- A bad word could be any length
- A User name could be any length

#### An easy and inefficient solution would be iterating over list of bad words and find the bad word in user name.

given a list of badwords = ["ass", "asshole", "fuck"]

#### Valid user names
- hello@domain.com 
- any@domain.com

#### Invalid user names
- kickass@domain.com
- kickstarassandhole@domain.com
- fuckingeasy@domain.com
