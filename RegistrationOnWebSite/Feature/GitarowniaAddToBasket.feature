Feature: GitarowniaAddToBasket
	In order to buy item
	I want to add item to my basket
	

@mytag
Scenario: Sucessfull adding item to basket
	Given User is on page: "http://www.gitarownia.pl/"
	When User enters "Brelok do kluczy fortepian"
	And Click Search button
	And Click searched item
	And Clik Add to bascet button
	And Click on bacst icon and goes to bascet
	Then Check if "Brelok do kluczy fortepian" is in bascet
