# EDBank Technical Manual

## 1051 Series Card Reader

Congratulations on your choice of card reader! We are sure your small business will benefit from the ease of user and reliabiility that the 1051 Series Card Reader can offer. Here's what you need to know to get started.

## Reading Card Numbers
The 1051 Series Card Reader comes with a simple software interface which can be integrated into your own custom built programs. To read a card number, simply call the ReadCard() method from the CardReader class which comes with this package. Note that this will
return the number of the card as a string. However, it is then left to the programmer to send this card number to our api for payment processing.

Note that, although we take care to deliver a quality product, the nature of the task means that a card number read by our hardware may be faulty.

## Processing Payments.
The 1051 Series Card reader works by establishing a TCP connection to port 3007 of our bank sever at IP address 85.188.165.135. After this, communication takes place in the form of UTF-8 encoded (JSON)[https://jsonformatter.curiousconcept.com/]. The following attributes must be given in JSON:   
+ **Customer ID** (*CustomerID*) : Your unique customer ID.  
+ **Creditcard Number** (*CreditCardNumber*) . The credit card number used to purchase goods. This must have 16 numerical digits.   
+ **Amount** (*Amount*) : The amount to charge to the card. This must be a positive number between 0 and 500. Larger withdrawals are not permitted.   

**Your unique Customer ID**: 456432ED  
**Port**: 3007  
**IP Address**:85.188.165.135