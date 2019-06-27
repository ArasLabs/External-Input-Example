# External Web Page for Input Into Aras Innovator

This is a very simple Visual Studio Web Application that includes several text boxes and a button.

A user will be able to fill in data into the text boxes, and once the user clicks the "Submit" button, 
a connection to Aras Innovator is made during which it creates a new PR with the given data provided by the user. 

## History

| Release                                                      | Notes                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [v1.0.1](https://github.com/ArasLabs/External-Input-Example/releases/tag/v1.0.1) | Tested 11.0 SP12, SP15; 12.0. Tested on IE/Edge, FF 60 ESR, Chrome |
| [v1.0.0](https://github.com/ArasLabs/External-Input-Example/releases/tag/v1.0.0) | First release. Tested on IE 11, Firefox 38 ESR, Chrome. <br />Though built and tested using Aras 11.0 SP9, this project should function in older releases of Aras 11.0 |

#### Supported Aras Versions

| Project                                                      | Aras                                       |
| ------------------------------------------------------------ | ------------------------------------------ |
| [v1.0.1](https://github.com/ArasLabs/External-Input-Example/releases/tag/v1.0.1) | 11.0 SP7+, SP12+, SP15; 12.0               |
| [v1.0.0](https://github.com/ArasLabs/External-Input-Example/releases/tag/v1.0.0) | 11 SP7, SP9; Old Community Board Migration |

## Installation

### Pre-requisites

1. Aras Innovator installed
2. Visual Studio (2015+)

### Install Steps

You will need to point the solution at the correct IOM file for your instance of Innovator. It should default to the last version of IOM you have used with Visual Studio, but resetting it to your current version is advised. Steps are as follows:

1. Open the solution in Visual Studio.
2. In the Solution Explorer pane:
   1. Under References, remove the IOM package
   2. Go to the CD Image for your version of Aras and unzip the IOM folder under Utilities to the location of your choice (you will need the .Net folder for this )
      - Alternate for if you do not have a CD Image: go to the Innovator/Client/bin folder on your install and select the IOM.dll file from there in the below step to add the reference.
   3. Return the project and add a reference
   4. Point to the location of the DLL
3. In the Project Properties (Project pulldown > [project name] Properties…) set the target framework to the version required by your install of Innovator or what the system warnings say regarding the correct version for your IOM file. (You can find this in the system requirements section of the installation documentation.)
4. Build/rebuild the solution. (And skip to step 2 of usage.)

## Usage

1. Open the solution in Visual Studio.
2. Start the External_Input_Example project.
   1. Select the browser you want to run it in.
3. Wait for the the web page to load.
4. Enter the log in credentials for the preferred Aras Innovator instance and the new PR data.
5. Click the submit button.
6. Once the connection is made and the new PR is created with the data provided by the user, a confirmation window will appear.

![Customized Dashboard](./Screenshots/PR-WebPage2.PNG)
*The PR Web Page with placeholders*

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request

For more information on contributing to this project, another Aras Labs project, or any Aras Community project, shoot us an email at araslabs@aras.com.

## Credits

Original code written by Aras Corporation Support for Aras Corporation.

Updated and Documented by Jillian Jakubowicz and Sam Poe for Aras Labs. @JillJakubowicz, @sampoearas

## License

Aras Labs projects are published to Github under the MIT license. See the [LICENSE file](./LICENSE.md) for license rights and limitations.
