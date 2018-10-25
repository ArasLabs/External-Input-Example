# External Web Page for Input Into Aras Innovator

This is a very simple Visual Studio Web Application that includes several text boxes and a button.

A user will be able to fill in data into the text boxes, and once the user clicks the "Submit" button, 
a connection to Aras Innovator is made during which it creates a new PR with the given data provided by the user. 

#### Built Using:
Aras 11.0 SP9

#### Versions Tested:
Aras 11.0 SP7, 11.0 SP9

#### Browsers Tested:
Internet Explorer 11, Firefox 38 ESR, Chrome

> Though built and tested using Aras 11.0 SP9, this project should function in older releases of Aras 11.0.

### Pre-requisites

1. Aras Innovator installed (version 11.0 SPx preferred)
2. Visual Studio (2015 preferred)

## Usage

1. Open the solution in Visual Studio.
2. Start the External_Input_Example project.
3. Wait for the the web page to load
4. Enter the log in credentials for the preferred Aras Innovator instance and the new PR data.
5. Click submit.
6. Once the connection is made and the new PR is created with the data provided by the user, a confirmation window will appear.

![Customized Dashboard](./Screenshots/PR%20Web%20Page%20Filled%20In.PNG)
*The PR Web Page with log in credentials and PR data filled out*

## Contributing

1. Fork it!
2. Clone your copy of the repository: `git clone https://github.com/YOUR-USERNAME/External-Input-Example.git`
3. Create your feature branch: `git checkout -b my-new-feature`
4. Commit your changes: `git commit -am 'Add some feature'`
5. Push to the branch: `git push origin my-new-feature`
6. Submit a pull request

For more information on contributing to this project, another Aras Labs project, or any Aras Community project, shoot us an email at araslabs@aras.com.

## Credits

Original code written by Aras Corporation Support for Aras Corporation.

Updated and Documented by Jillian Jakubowicz for Aras Labs. @JillJakubowicz

## License

Aras Labs projects are published to Github under the MIT license. See the [LICENSE file](./LICENSE.md) for license rights and limitations.
