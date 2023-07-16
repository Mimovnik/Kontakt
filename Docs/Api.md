# Kontakt API

- [Kontakt API](#kontakt-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
  - [Contacts](#contacts)
    - [Create Contact](#create-contact)
      - [Request](#request)
      - [Response](#response)
    - [List Contacts](#list-contacts)
      - [Request](#request-1)
      - [Response](#response-1)
    - [Get Contact](#get-contact)
      - [Request](#request-2)
      - [Response](#response-2)
    - [Update Contact](#update-contact)
      - [Request](#request-3)
      - [Response](#response-3)
    - [Delete Contact](#delete-contact)
      - [Request](#request-4)
      - [Response](#response-4)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Jan",
  "lastName": "Kowalski",
  "email": "jankowalski@example.com",
  "password": "MyPassword123"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Jan",
  "lastName": "Kowalski",
  "email": "jankowalski@example.com",
  "token": "eyJhb..9dgcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "email": "johncena@example.com",
  "password": "JohnCenaIsTheBest123!"
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Cena",
  "email": "johncena@example.com",
  "token": "eyJhb..9dgcnXoY"
}
```

## Contacts

### Create Contact

#### Request

```js
POST {{host}}/contacts
```

#### Response

```js
201 CREATED
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Cena",
  "email": "johncena@example.com",
  "password": "WhyIsTherePasswordFieldInContacts?",
  "category": "private",
  "subcategory": "friend",
  "phoneNumber": 111222333,
  "birthDate": "1977-04-23"
}
```

### List Contacts

#### Request

```js
GET {{host}}/contacts
```

#### Response

```js
200 OK
```

```json
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "John",
    "lastName": "Cena",
    "email": "johncena@example.com",
    "password": "WhyIsTherePasswordFieldInContacts?",
    "category": "private",
    "subcategory": "friend",
    "phoneNumber": 111222333,
    "birthDate": "1977-04-23"
},
{
    "id": "a88c2d9a-eb3e-4075-95ff-b920b22bb104",
    "firstName": "Elon",
    "lastName": "Musk",
    "email": "elonmusk@example.com",
    "password": "ILoveRockets123!",
    "category": "business",
    "subcategory": "boss",
    "phoneNumber": 333222111,
    "birthDate": "1971-02-01"
}
```

### Get Contact

#### Request

```js
GET {{host}}/contacts/{{id}}
```

#### Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Cena",
  "email": "johncena@example.com",
  "password": "WhyIsTherePasswordFieldInContacts?",
  "category": "private",
  "subcategory": "friend",
  "phoneNumber": 111222333,
  "birthDate": "1977-04-23"
}
```

### Update Contact

#### Request

```js
UPDATE {{host}}/contacts/{{id}}
```

#### Response

```js
200 OK
```

### Delete Contact

#### Request

```js
DELETE {{host}}/contacts/{{id}}
```

#### Response

```js
200 OK
```
