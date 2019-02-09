use kevindb;

CREATE TABLE Prices(ItemID INTEGER(5) AUTO_INCREMENT NOT NULL, Type VARCHAR(100), Name VARCHAR(100), Price DECIMAL(10,2), Price2 DECIMAL(10,2), Description VARCHAR(255), CONSTRAINT PricesPK PRIMARY KEY(ItemID));


/*Manicure*/
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","Classic Manicure", 14.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","Sports Manicure", 18.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","Soak Off Gel(or Shellac) Manicure", 32.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","Deluxe Manicure", 35.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","Organic Dipping Powder Manicure", 40.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Manicure","VIP Luxary Manicure", 45.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
/*Pedicure*/
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","Classic Pedicure", 25.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","Deluxe Spa Pedicure", 36.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","On the Rock Pedicure", 45.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","Soak-Off Gel(or Shellac) Pedicure", 45.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","VIP Luxury Pedicure", 59.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Pedicure","The Volcano Pedicure", 70.00,"Hands soak, nails and cuticle shaping, massage, finshed with buffing.");

/*Combo Manicure/Pedicure*/
INSERT INTO Prices(Type,Name,Price)
VALUES("Combo Manicure/Pedicure","Spa Pedicure & Manicure", 35.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Combo Manicure/Pedicure","Spa Pedicure & Gel Manicure", 57.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Combo Manicure/Pedicure","VIP Luxury Pedicure & Deluxe Manicure", 80.00);

/*NAIL ENHANCEMENTS*/
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("Nail Enhancement","Fullset Acrylic Powder w/Tips or Overlay", 32.00,25.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("Nail Enhancement","Fullset Acrylic Powder w/Gel Polish", 40.00,32.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("Nail Enhancement","Fullset Acrylic Powder Pink & White w/Gel Top", 40.00,33.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("Nail Enhancement","Color or Glitter Powder Tip", 45.00,35.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("Nail Enhancement","IBD Builder Gel Full Set", 45.00,35.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Nail Enhancement","Fullset Organic Dipping Powder with Tips", 45.00);
/*ADD-ONS*/
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","French Polish", 5.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","2 Designs", 5.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","Callus Treatment", 6.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","Hand or Feet Paraffin", 10.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","Nail Repair (per nail)", 3.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","Take Off Acrylic", 10.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Addons","Take Off Gel", 9.00);

/*KIDS SERVICE*/
INSERT INTO Prices(Type,Name,Price)
VALUES("Kids","Manicure", 10.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Kids","Polish Hands", 5.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Kids","Pedicure", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Kids","Polish Toes", 7.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Kids","Mani & Pedi",25.00);

/*WAXING*/
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Eyebrows", 12.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Upper Lip", 8.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Chin", 10.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Chin and Neck", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Sideburn", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Full Face", 40.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Underarm", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Upper Lip", 8.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Chin", 10.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Chin and Neck", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Sideburn", 15.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Half Arm", 25.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Full Arm", 37.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Half Leg", 30.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Full Leg", 47.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Bikini", 30.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Brazilian", 40.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("Waxing","Back", 45.00);
/*Facial Treatments*/
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","Express Facial (30min)", 35.00,"In just 30 minutes, our Express (Mini) Facial is pickme- up. Cleansing, exfoliation, light extractions and a mask will leave your skin with a healthy glow.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","Teen Facial (45min)", 45.00,"A facial formulated for the overactive teenage skin. Cleansing, exfoliation, steam, extraction and mask.
");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","European Facial (60min)", 55.00,"A purifying treatment for any skin types includes steaming, cleansing, mask treatment, massage and moisturized.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","Deep Cleansing Facial (60min)", 60.00,"refines and normalizes troubled skin. The service includes manual and/or (discomfort-free) sonic extractions and a purifying mask which is perfect for detoxifying, balancing sebum production and beautifying skin.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","Derma-Planing Facial (60min)", 65.00,"Derma-Planing is the painless process of scraping away dead skin and those Vellus “peach fuzz” hair, leaving your skin with a smoother, brighter complexion. Make up will go on smoother & blend more easily. Your skin care products will be more effective by penetrating deeper. This Facial includes a custom mask and antiaging serum, finishing cream, sun protection and home care instruction.");
INSERT INTO Prices(Type,Name,Price,Description)
VALUES("Facials","Diamond Microdermabrasion Facial", 75.00,"A more gentle approach for sun damaged, fine lines, wrinkles and dehydrated skin. Our diamond crystalfree approach uses a clean and sanitized stainless steel abrasive tip. As the diamond tip glides across the skin surface, it loosens dull dead skin cells and helps smooth lines and wrinkles. This treatment can be performed with a vacuum to lift away cellular debris or alone to help prevent capillary damage.");


/*LASHES*/
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("LASHES","Full Set Classic (Mascara Look)", 100.00,50.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("LASHES","Full Set Hybrid(Mix of Classic & Volume)", 130.00,65.00);
INSERT INTO Prices(Type,Name,Price,Price2)
VALUES("LASHES","Full Set of Volume (Strip Lash ook)", 175.00,90.00);


/*LASH LIFT*/
INSERT INTO Prices(Type,Name,Price)
VALUES("LASHLIFT","Lash Lift on Natural Lashes", 60.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("LASHLIFT","Lash Lift with Tint", 75.00);

/*PERMANENT MAKEUP*/
INSERT INTO Prices(Type,Name,Price)
VALUES("PermanentMakeUp","Eyebrow Microblading", 300.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("PermanentMakeUp","Eyebrow Ombre", 300.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("PermanentMakeUp","Eyebrow Combo", 350.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("PermanentMakeUp","Eyeliner", 200.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("PermanentMakeUp","Lips", 300.00);

/*MAKEUP AND UPDOS (BY APPOINTMENT ONLY)*/
INSERT INTO Prices(Type,Name,Price)
VALUES("MakeupUpdos","Makeup Application", 55.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("MakeupUpdos","Makeup with Fake Lashes", 64.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("MakeupUpdos","Makeup (Eyes only)", 35.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("MakeupUpdos","Hair Curling", 45.00);
INSERT INTO Prices(Type,Name,Price)
VALUES("MakeupUpdos","Updos", 65.00);


