Builder Parameter pattern based on the following Scenario: Explicitly force the user to interact with the Builder.

In this case:

Email: Entity is set with the 4 basic members of an email. Kept public and some parts of it are optional, like 'Subject'.

EmailBuilder: is implemented with Fluent aproach.

MailService: Nests this Builder and 'SendEmail' method takes a function, not a set of parameters or prepackaged object. Then, the internal mechanics of 'MailService' process a fully initialized 'Email'.
(So, instead of storing a reference to an e-mail internally, the Builder gets that reference in the constructor argument. 'EmailBuilder' doesn't expose 'Email' publicity in its API.)
