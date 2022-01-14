# tdd-kata

Given I provide a pokemon number 25
When I ask for their name
Then I should see Pikachu

Client http https://pokeapi.co/api/v2/
Parameter 25
Response { ... name: "pikachu" ... }

Happy Path

    I can ingress 25
    The api response is 200 and with the specified structure { ... name .. }
    Then the response is 200 {Name: "Pikachu"} => Contract    (Diseño)

Sad Path

    I can ingress Pikachu
    The api response is 400
    Then the response is { Error: "Should be Number"}

