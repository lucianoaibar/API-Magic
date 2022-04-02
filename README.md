# API Magic

API Magic is a Chromium based web browser for frontend to backend call redirection.


## Use case

Imagine that you made changes to an API microservice and want to test it from the frontend.\
So you would need to do the following:
1) to deploy locally the rest of the microservices
2) also the frontend

Unfortunately this is not always an option.\
For several reasons (i.e. not allowed to clone the required repositories).\
But... what if we could reuse an already deployed frontend in another environment like "testing", "integration" or "pre-prod" ?

With API Magic is possible to catch a backend call and redirect it to another destination.


## Projects organization

Projects are organized as sub-folders inside Windows "Documents" -> "API Magic" folder.

```
Documents
 |_ API Magic
     |_ Project 1
     |_ Another project
     |_ ...
```

Inside each sub-folder, at least 4 files are required:

* settings.json
* routes_file.json
* routes_text.json
* routes_url.json


## Example

When the application is run, the "Documents/API Magic" folder is created and inside there is an example project with name "Demo with ReqRes".
