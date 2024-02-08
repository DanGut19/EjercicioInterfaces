// See https://aka.ms/new-console-template for more information
using EjercicioInterfaces;

Console.WriteLine("EjercicioInterfaz");

Panqueques panqueques = new Panqueques();
panqueques.Nombre = "Panqueques";
panqueques.Ingrediente1 = "1 taza de harina leudante o harina de repostería";
panqueques.Ingrediente2 = "1 huevo";
panqueques.Ingrediente3 = "1 chorro de aceite de oliva";
panqueques.Ingrediente4 = "3/4 taza de leche (180 mililitros)";
panqueques.Ingrediente5 = "1 cucharadita de mantequilla";
panqueques.Ingrediente6 = "1 chorro de miel";
panqueques.LitaUtensilios = "Moldes para panqueques - Espátula de silicona - Sartén (opcional) - Bol";
panqueques.Imprimir();

Pizza pizza = new Pizza();
pizza.Nombre = "Pizza";
pizza.Ingrediente1 = "1 kilogramo de harina de fuerza (también conocida como harina 00)";
pizza.Ingrediente2 = "1 cucharadita de sal fina";
pizza.Ingrediente3 = "2½ tazas de agua tibia";
pizza.Ingrediente4 = "2 cucharadas soperas de aceite de oliva)";
pizza.Ingrediente5 = "30 gramos de levadura fresca";
pizza.LitaUtensilios = "Rodillo de madera - Papel de horno - Bol";
pizza.Imprimir();

Pan_Dulce_de_Leche pan_Dulce_De_Leche = new Pan_Dulce_de_Leche();
pan_Dulce_De_Leche.Nombre = "Pan Dulce de Leche";
pan_Dulce_De_Leche.Ingrediente1 = "240 gramos de harina";
pan_Dulce_De_Leche.Ingrediente2 = "1 huevo";
pan_Dulce_De_Leche.Ingrediente3 = "35 gramos de manteca derretida";
pan_Dulce_De_Leche.Ingrediente4 = "100 centímetros cúbicos de leche tibia";
pan_Dulce_De_Leche.Ingrediente5 = " 1/2 cucharadita de sal";
pan_Dulce_De_Leche.Ingrediente6 = "1 cucharada postre de miel";
pan_Dulce_De_Leche.Ingrediente7 = "10 gramos de levadura";
pan_Dulce_De_Leche.Ingrediente8 = "50 gramos de azúcar (1/4 taza)";
pan_Dulce_De_Leche.Imprimir();