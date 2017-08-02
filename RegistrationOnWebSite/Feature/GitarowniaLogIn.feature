Feature: GitarowniaLogIn
	
	I want to log in on gitarownia.pl site

@mytag
Scenario: Succesfull LogIn on page
	Given the user is on page "https://gitarownia.iai-shop.com/signin.php"
	Then he enters "KowalskiJan" as login
	Then he enters "test111" as password
	When click sign In button
	Then User is on page: "https://gitarownia.iai-shop.com/login.php"
	
