#ניהול בנק<br>
מערכת לניהול חשבונות בנק, באמצעות המערכת ניתן לעקוב אחר פרטי החשבון, ליצור חשבון חדש ולנהל את כלל החשבונות של הלקוחות.<br>
ישויות:<br>
•	חשבון בנק<br>
•	פקידים<br>
•	לקוחות<br>

מיפוי Routes  לחשבון בנק:<br>
•	שליפת רשימת כלל החשבונות Get https://bank.co.il/accounts  
•	שליפת חשבון לפי מזהה חשבוןGet https://bank.co.il/accounts/5874 
•	הוספת חשבון חדש Post https://bank.co.il/accounts
•	עדכון חשבון Put https://bank.co.il/accounts/5874 
•	מחיקת חשבון לפי מזהה Delete https://bank.co.il/accounts/5874 
•	עדכון סטטוס חשבון: Put https://bank.co.il/accounts/5874/status

מיפוי Routes  לפקידים:
•	שליפת רשימת הפקידים Get https://bank.co.il/officials  
•	שליפת רשימת הפקידים לפי סניףGet https://bank.co.il/officials/branch  
•	שליפת פקיד לפי מזהה Get https://bank.co.il/officials/1
•	הוספת פקיד Post https://bank.co.il/officials
•	עדכון פרטי פקיד Put https://bank.co.il/officials/1
•	מחיקת פקיד לפי מזהה Delete https://bank.co.il/officials/1

מיפוי Routes  ללקוחות:
•	שליפת רשימת הלקוחות Get https://bank.co.il/customers  
•	שליפת רשימת לקוחות לפי כתובתGet https://bank.co.il/customers/address  
•	שליפת לקוח לפי מזהה Get https://bank.co.il/customers/1
•	הוספת לקוח Post https://bank.co.il/customers
•	עדכון פרטי לקוח Put https://bank.co.il/customers/1
•	מחיקת לקוח לפי מזהה Delete https://bank.co.il/customers/1
