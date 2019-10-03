BDD spes

Scenario: prompt the user to enter a string
    Given The user has just run the program 
    Then prompt the user to enter a string


Scenario: A user can enter a string to be translated and get a result
    Given the user has entered a string and is at least 5 characters
    When the user hits 'enter'
    Then translate and display the result and ask user if they want to translate another string

Scenario: A user can enter a string to be translated and get a result
    Given the user has entered a string and is less than 5 characters
    When the user hits 'enter'
    Then give message and go back to prompt

Scenario: ask user if they want to translate another string - yes
    Given the user enters yes
    When they hit enter
    Then prompt for input


Scenario: ask user if they want to translate another string - no
    Given the user enters no
    When they hit enter
    Then display exit message






TDD specs

replace a word (string in the array) with another pre-defined word