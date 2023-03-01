Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BDDWithSpecflow/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Background: 
Given User Cleared the temp Records

@rtc
Scenario: Book a Bus Ticket and Print
Given User Launched Apsrtc Application
When User Fills Ticket Details
Then User Could able to book the ticket
@rtc
Scenario: Book a Bus Ticket and Track Service
Given User Launched Apsrtc Application
When User Fills Ticket Details
Then User Could able to book the ticket
When User Track the Service With Ticket Number
Then User Could able to track the service

@rtc
Scenario: Book a Bus Ticket and Cancel Ticket
Given User Launched Apsrtc Application
When User Fills Ticket Details
Then User Could able to book the ticket
When User Cancel the ticket With Ticket Number
Then User Could able to Cancel the ticket

@smoke
Scenario: Subtract two numbers
 Given user gave the first number
 And user gave the second number
 When the two numbers are subtracted
 Then validate the result

@smoke
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@regression @smoke
Scenario: Login to Application
	Given I Launched Application with 'https://gmail.com'
	When I enter user credentials with 'nag123@gmail.com' 'abcd1234'
	Then I should be logged in Successfully

@datadriven
Scenario Outline: Login To Application DataDriven
	Given User Launched Application '<URL>'
	When User Gave Login Details '<UserName>' '<PassWord>'
	Then User should be logged in Successfully

	Examples: 
	| URL                   | UserName | PassWord |
	| https://gmail.com     | ram      | abcd     |
	| https://dev.gmail.com | ravi     | xyz123   |
	| https://qa.gmail.com  | ramesh   | hfg456   |
	| https://gmail.com     | ram      | abcd     |
	| https://dev.gmail.com | ravi     | xyz123   |
	| https://qa.gmail.com  | ramesh   | hfg456   |




