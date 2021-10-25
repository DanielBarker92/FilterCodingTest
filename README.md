# FilterStringCodingTest

## Overview

This Azure Functions project filters out prime numbers from a given list of integers and returns the non-prime numbers in an ordered list. 

You can call this endpoint via this URL: http://localhost:7071/api/filter 

List of integers should be passed in via the 'value' querystring parameter e.g.

- Request: http://localhost:7071/api/filter?value=1,12,7,5,7,9,16,4
- Response: 1,4,9,12,16

## Assumptions

- I'm assuming this is a small part of a bigger project and am not throwing any exceptions. I'm more inclined to throw exceptions higher up in cases of null or empty.
- Letters are to be stripped out before being passed into the filter.
- I'd usually want to follow a similar pattern to Linq and make the sort and ordering extension methods but have done them as "services" due to the wording of the test so that they are system configured (via Dependency Injection).