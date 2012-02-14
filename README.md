# SoundCloud C# API Wrapper

## Introduction

A wrapper for the SoundCloud API written in C# with support for authentication using [OAuth 2.0](http://oauth.net/2/).

## Getting started

Check out the [getting started](https://github.com/iEmiya/SoundCloudProvider/wiki/OAuth-2) wiki entry for further reference on how to get started. Also make sure to see project `SoundCloudTests` for some example code.


## Examples

The wrapper includes convenient methods used to perform HTTP requests on behalf of the authenticated user. Below you'll find a few quick examples.

Ofcourse you need to handle the authentication first before being able to request and modify protect resources as demonstrated below.

### GET

``` csharp
var tracksConsole = new TracksClientImp(token);
var track = tracksConsole.GetTrack(track_id);
```



## Feedback and questions

Found a bug or missing a feature? Don't hesitate to create a new issue here on GitHub. Or contact me [directly](https://github.com/iEmiya).

## License

Copyright (c) 2012 Emiya

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
