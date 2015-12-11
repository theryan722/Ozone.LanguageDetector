# Ozone.LanguageDetector
![License](https://img.shields.io/badge/license-Apache-blue.svg)
![Release](https://img.shields.io/badge/release-v1.0.1-blue.svg)
![Status](https://img.shields.io/badge/status-Active-brightgreen.svg)
![Current Release](https://img.shields.io/badge/current%20release-Stable-brightgreen.svg)
![Current Build](https://img.shields.io/badge/current%20build-Stable-brightgreen.svg)

A .Net library that determines the programming language used in a snippet or file.

###Supported Languages
This library can currently detect over 20 different languages. A complete list can be viewed [here](https://github.com/theryan722/Ozone.LanguageDetector/wiki/Supported-Languages).

###Upcoming Update
I am in the process of revamping and improving the accuracy of language detection. This will also lead to improvements in differentiating between various C-like languages.

###Usage
First off, you need to reference the library in your project.

After that, there are two methods available in the **Ozone.LanguageDetector.Detector** class:

* DetectLanguageFromFile
* DetectLanguageFromSnippet

**DetectLanguageFromFile** determines the programming language based on the file extension used in the file name. **DetectLanguageFromSnippet** determines the programming language of a code snippet.

Both return a language name from an enum (Language.Language). If the language cannot be determined, then Language.Unknown is returned.

Check out the wiki for examples and further help.

###Binaries
You can download the library from the [releases](https://github.com/theryan722/Ozone.LanguageDetector/releases/) page.

###Project Status
This project is under active development and will be continually improved over time. Contributions are welcome of course.

###Future Plans
In the future I plan on creating a GUI application and console application that utilize the library.

###License
Copyright 2015 Ryan O'Day

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
