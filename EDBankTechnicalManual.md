# EDBank Technical Manual

## 1051 Series Card Reader

Congratulations on your choice of card reader! We are sure your small business will benefit from the ease of user and reliabiility that the 1051 Series Card Reader can offer. Here's what you need to know to get started.

# Connection

The 1051 Series Card reader works by establishing a TCP connection to port 3007 of our bank sever at IP address ........ After this, communication takes place in the form of UTF-8 encoded JSON. The following attributes must be given in JSON:   
+ Customer ID (CustomerID) : Your unique customer ID.
+ Creditcard Number (CreditCardNumber) . The credit card number used to purchase goods. This must have 16 numerical digits. 
+ Amount (Amount) : The amount to charge to the card. This must be a positive number between 0 and 500. Larger withdrawals are not permitted. 