Feature: RegistrationOnWebSite
	As a customer,
	Iwant to register on Web site 
	so theat I can make shopping.

@mytag
Scenario: Successful Registration
	Given the user is on "https://gitarownia.iai-shop.com/client-new.php?register"
    When he enters "Jan" as name
	And he enters "Kowalski" as second name
	And he enters "Wileńska 25" as street number
	And he enters "03414" as zip-code 
	And he enters "Warszawa" as city
	And he Sellect "Litwa" as country
	And he accept "no" in delivery address
	And he enters "marzenakolek.mojapoczta@o2.pl" as email
	And he enters "696010000" as telephone number
	And he enters "Maja333" as login
	And he enters "Maja333" as password
	And he enters "Maja333" as repeat password
	And he accept "Rules"
	And he Submits request on account registration
	Then he can go to "https://gitarownia.iai-shop.com/client-new.php?register"
