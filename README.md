# API Magic

Imagine that you made changes to an API microservice and want to test it from the frontend.\
So you would need to do the following:
1) to deploy locally the rest of the microservices
2) also the frontend

Unfortunately this is not always an option.\
For several reasons (i.e. not allowed to clone the required repositories).\
But... what if we could reuse an already deployed frontend in another environment (like "testing", "integration" or "pre-prod") ?

API Magic is a Chromium based web browser that allows to redirect a frontend-to-backend call to another destination.
