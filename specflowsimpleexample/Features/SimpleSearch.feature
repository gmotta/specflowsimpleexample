Feature:
	Basic Search

Scenario:  Search For 'Eloquent Ruby'
    Given I am on the Bing Home Page
    When I search for "Eloquent Ruby"
    And I follow the "Eloquent Ruby" link
    Then I should see the title "Eloquent Ruby | Companion site to the book Eloquent Ruby"