﻿module Ploeh.Numsense.BulgarianExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                                                       "нула",          0)>]
[<InlineData(                                                                      " нула",          0)>]
[<InlineData(                                                                      "нула ",          0)>]
[<InlineData(                                                                   "  нула  ",          0)>]
[<InlineData(                                                                       "Нула",          0)>]
[<InlineData(                                                                       "НУЛА",          0)>]
[<InlineData(                                                                    " нУЛа\t",          0)>]
[<InlineData(                                                                       "едно",          1)>]
[<InlineData(                                                                       "ЕДНО",          1)>]
[<InlineData(                                                                        "две",          2)>]
[<InlineData(                                                                       " две",          2)>]
[<InlineData(                                                                        "три",          3)>]
[<InlineData(                                                                      "три  ",          3)>]
[<InlineData(                                                                     "четири",          4)>]
[<InlineData(                                                                  "  четири ",          4)>]
[<InlineData(                                                                        "пет",          5)>]
[<InlineData(                                                                        "ПеТ",          5)>]
[<InlineData(                                                                       "шест",          6)>]
[<InlineData(                                                                   "  ШЕСТ  ",          6)>]
[<InlineData(                                                                      "седем",          7)>]
[<InlineData(                                                                  "    сеДем",          7)>]
[<InlineData(                                                                       "осем",          8)>]
[<InlineData(                                                                       "оСЕМ",          8)>]
[<InlineData(                                                                      "девет",          9)>]
[<InlineData(                                                                    "ДеВет  ",          9)>]
[<InlineData(                                                                      "десет",         10)>]
[<InlineData(                                                                  "единайсет",         11)>]
[<InlineData(                                                                  "дванайсет",         12)>]
[<InlineData(                                                                  "тринайсет",         13)>]
[<InlineData(                                                               "четиринайсет",         14)>]
[<InlineData(                                                                  "петнайсет",         15)>]
[<InlineData(                                                                 "шестнайсет",         16)>]
[<InlineData(                                                                "седемнайсет",         17)>]
[<InlineData(                                                                 "осемнайсет",         18)>]
[<InlineData(                                                                "деветнайсет",         19)>]
[<InlineData(                                                                    "двайсет",         20)>]
[<InlineData(                                                             "двайсет и едно",         21)>]
[<InlineData(                                                             "двайсет-и-едно",         21)>]
[<InlineData(                                                                    "трийсет",         30)>]
[<InlineData(                                                           "трийсет-и-четири",         34)>]
[<InlineData(                                                            "тридесет-и-осем",         38)>]
[<InlineData(                                                                  "четиресет",         40)>]
[<InlineData(                                                           "четиресет-и-едно",         41)>]
[<InlineData(                                                         "четиресет и четири",         44)>]
[<InlineData(                                                                   "петдесет",         50)>]
[<InlineData(                                                           "петдесет и седем",         57)>]
[<InlineData(                                                                     "шейсет",         60)>]
[<InlineData(                                                               "шейсет и пет",         65)>]
[<InlineData(                                                                 "седемдесет",         70)>]
[<InlineData(                                                         "седемдесет-и-седем",         77)>]
[<InlineData(                                                         "седемдесет и девет",         79)>]
[<InlineData(                                                                  "осемдесет",         80)>]
[<InlineData(                                                           "осемдесет и шест",         86)>]
[<InlineData(                                                                 "деветдесет",         90)>]
[<InlineData(                                                           "деветдесет и три",         93)>]
[<InlineData(                                                                        "сто",        100)>]
[<InlineData(                                                                        "Сто",        100)>]
[<InlineData(                                                                 "сто и едно",        101)>]
[<InlineData(                                                                 "сто-и-едно",        101)>]
[<InlineData(                                                                     "двеста",        200)>]
[<InlineData(                                                     "двеста трийсет и седем",        237)>]
[<InlineData(                                                    "триста седемдесет и пет",        375)>]
[<InlineData(                                                  "четиристотин и деветдесет",        490)>]
[<InlineData(                                                  "петстотин шестдесет и три",        563)>]
[<InlineData(                                                   "шестстотин и осемнадесет",        618)>]
[<InlineData(                                             "седемстотин седемдесет и седем",        777)>]
[<InlineData(                                                           "осемстотин и пет",        805)>]
[<InlineData(                                                          "осемстотин и шест",        806)>]
[<InlineData(                                                         "осемстотин-и-седем",        807)>]
[<InlineData(                                               "деветстотин петдесет и девет",        959)>]
[<InlineData(                                                                     "хиляда",       1000)>]
[<InlineData(                                                              "хиляда и едно",       1001)>]
[<InlineData(                                                               "хиляда и две",       1002)>]
[<InlineData(                                                     "хиляда шейсет и четири",       1064)>]
[<InlineData(                                                                 "две хиляди",       2000)>]
[<InlineData(                                     "осем хиляди седемстотин двайсет и едно",       8721)>]
[<InlineData(                                             "девет-хиляди-сто-двайсет-и-три",       9123)>]
[<InlineData(                                                               "десет хиляди",      10000)>]
[<InlineData(                                                    "десет хиляди сто и едно",      10101)>]
[<InlineData(                                                     "десет-хиляди-сто-и-две",      10102)>]
[<InlineData(                             "двайсет и три хиляди петстотин шейсет и четири",      23564)>]
[<InlineData(                                                   "осемдесет хиляди и десет",      80010)>]
[<InlineData(                                                                 "сто хиляди",     100000)>]
[<InlineData(                                                                 "сто-хиляди",     100000)>]
[<InlineData(                                                          "сто хиляди и едно",     100001)>]
[<InlineData(                       "триста и деветнайсет хиляди триста четиресет и девет",     319349)>]
[<InlineData(                                                                "един милион",    1000000)>]
[<InlineData(                                                         "един милион и едно",    1000001)>]
[<InlineData(                                                        "два милиона и десет",    2000010)>]
[<InlineData(                                                   "два милиона и единадесет",    2000011)>]
[<InlineData(                                              "шест милиона и трийсет хиляди",    6030000)>]
[<InlineData(                  "девет милиона двеста и една хиляди шестстотин и осемдесет",    9201680)>]
[<InlineData(                                                              "десет милиона",   10000000)>]
[<InlineData(                                                      "десет милиона и девет",   10000009)>]
[<InlineData(                                                    "двадесет и един милиона",   21000000)>]
[<InlineData(         "четиресет и седем милиона шестстотин шейсет и една хиляди и шейсет",   47661060)>]
[<InlineData(                                                                "сто милиона",  100000000)>]
[<InlineData(                                                                "сто-милиона",  100000000)>]
[<InlineData(                                                       "двеста и пет милиона",  205000000)>]
[<InlineData(                                                     "триста-и-седем-милиона",  307000000)>]
[<InlineData(              "четиристотин шейсет и един милиона шейсет хиляди и шестстотин",  461060600)>]
[<InlineData(                                                               "един-милиард", 1000000000)>]
[<InlineData(                                                               "два-милиарда", 2000000000)>]
[<InlineData(      "два милиарда четиридесет и девет милиона шестстотин и петдесет хиляди", 2049650000)>]
[<InlineData(
    "два милиарда сто четиресет и седем милиона четиристотин осемдесет и три хиляди шестстотин четиресет и седем", 
    System.Int32.MaxValue)>]
let ``tryOfBulgarian returns correct result`` (bulgarian, expected) = 
    let actual = Numeral.tryParseBulgarian bulgarian
    Some expected =! actual

[<Theory>]
[<InlineData(0, "нула")>]
[<InlineData(1, "едно")>]
[<InlineData(2, "две")>]
[<InlineData(3, "три")>]
[<InlineData(4, "четири")>]
[<InlineData(5, "пет")>]
[<InlineData(6, "шест")>]
[<InlineData(7, "седем")>]
[<InlineData(8, "осем")>]
[<InlineData(9, "девет")>]
[<InlineData(10, "десет")>]
[<InlineData(11, "единайсет")>]
[<InlineData(12, "дванайсет")>]
[<InlineData(13, "тринайсет")>]
[<InlineData(14, "четиринайсет")>]
[<InlineData(15, "петнайсет")>]
[<InlineData(16, "шестнайсет")>]
[<InlineData(17, "седемнайсет")>]
[<InlineData(18, "осемнайсет")>]
[<InlineData(19, "деветнайсет")>]
[<InlineData(20, "двайсет")>]
[<InlineData(21, "двайсет-и-едно")>]
[<InlineData(30, "трийсет")>]
[<InlineData(34, "трийсет-и-четири")>]
[<InlineData(40, "четиресет")>]
[<InlineData(42, "четиресет-и-две")>]
[<InlineData(50, "петдесет")>]
[<InlineData(58, "петдесет-и-осем")>]
[<InlineData(60, "шейсет")>]
[<InlineData(65, "шейсет-и-пет")>]
[<InlineData(70, "седемдесет")>]
[<InlineData(79, "седемдесет-и-девет")>]
[<InlineData(80, "осемдесет")>]
[<InlineData(86, "осемдесет-и-шест")>]
[<InlineData(90, "деветдесет")>]
[<InlineData(93, "деветдесет-и-три")>]
[<InlineData(100, "сто")>]
[<InlineData(101, "сто-и-едно")>]
[<InlineData(110, "сто-и-десет")>]
[<InlineData(114, "сто-и-четиринайсет")>]
[<InlineData(135, "сто-трийсет-и-пет")>]
[<InlineData(200, "двеста")>]
[<InlineData(282, "двеста-осемдесет-и-две")>]
[<InlineData(331, "триста-трийсет-и-едно")>]
[<InlineData(407, "четиристотин-и-седем")>]
[<InlineData(520, "петстотин-и-двайсет")>]
[<InlineData(666, "шестстотин-шейсет-и-шест")>]
[<InlineData(798, "седемстотин-деветдесет-и-осем")>]
[<InlineData(857, "осемстотин-петдесет-и-седем")>]
[<InlineData(999, "деветстотин-деветдесет-и-девет")>]
[<InlineData(1000, "хиляда")>]
[<InlineData(1001, "хиляда-и-едно")>]
[<InlineData(1010, "хиляда-и-десет")>]
[<InlineData(1066, "хиляда-шейсет-и-шест")>]
[<InlineData(1337, "хиляда-триста-трийсет-и-седем")>]
[<InlineData(1984, "хиляда-деветстотин-осемдесет-и-четири")>]
[<InlineData(2015, "две-хиляди-и-петнайсет")>]
[<InlineData(3000, "три-хиляди")>]
[<InlineData(3297, "три-хиляди-двеста-деветдесет-и-седем")>]
[<InlineData(4080, "четири-хиляди-и-осемдесет")>]
[<InlineData(5011, "пет-хиляди-и-единайсет")>]
[<InlineData(6025, "шест-хиляди-двайсет-и-пет")>]
[<InlineData(7441, "седем-хиляди-четиристотин-четиресет-и-едно")>]
[<InlineData(8513, "осем-хиляди-петстотин-и-тринайсет")>]
[<InlineData(9000, "девет-хиляди")>]
[<InlineData(10000, "десет-хиляди")>]
[<InlineData(12001, "дванайсет-хиляди-и-едно")>]
[<InlineData(23456, "двайсет-и-три-хиляди-четиристотин-петдесет-и-шест")>]
[<InlineData(32109, "трийсет-и-две-хиляди-сто-и-девет")>]
[<InlineData(40404, "четиресет-хиляди-четиристотин-и-четири")>]
[<InlineData(56789, "петдесет-и-шест-хиляди-седемстотин-осемдесет-и-девет")>]
[<InlineData(60015, "шейсет-хиляди-и-петнайсет")>]
[<InlineData(71003, "седемдесет-и-една-хиляди-и-три")>]
[<InlineData(80522, "осемдесет-хиляди-петстотин-двайсет-и-две")>]
[<InlineData(98765, "деветдесет-и-осем-хиляди-седемстотин-шейсет-и-пет")>]
[<InlineData(100000, "сто-хиляди")>]
[<InlineData(100001, "сто-хиляди-и-едно")>]
[<InlineData(100010, "сто-хиляди-и-десет")>]
[<InlineData(101010, "сто-и-една-хиляди-и-десет")>]
[<InlineData(200000, "двеста-хиляди")>]
[<InlineData(321000, "триста-двайсет-и-една-хиляди")>]
[<InlineData(411416, "четиристотин-и-единайсет-хиляди-четиристотин-и-шестнайсет")>]
[<InlineData(530121, "петстотин-и-трийсет-хиляди-сто-двайсет-и-едно")>]
[<InlineData(600000, "шестстотин-хиляди")>]
[<InlineData(788000, "седемстотин-осемдесет-и-осем-хиляди")>]
[<InlineData(876540, "осемстотин-седемдесет-и-шест-хиляди-петстотин-и-четиресет")>]
[<InlineData(908077, "деветстотин-и-осем-хиляди-седемдесет-и-седем")>]
[<InlineData(1000000, "един-милион")>]
[<InlineData(2000002, "два-милиона-и-две")>]
[<InlineData(2012000, "два-милиона-и-дванайсет-хиляди")>]
[<InlineData(2500000, "два-милиона-и-петстотин-хиляди")>]
[<InlineData(3040506, "три-милиона-четиресет-хиляди-петстотин-и-шест")>]
[<InlineData(4321000, "четири-милиона-триста-двайсет-и-една-хиляди")>]
[<InlineData(5004621, "пет-милиона-четири-хиляди-шестстотин-двайсет-и-едно")>]
[<InlineData(6982001, "шест-милиона-деветстотин-осемдесет-и-две-хиляди-и-едно")>]
[<InlineData(7000000, "седем-милиона")>]
[<InlineData(8000220, "осем-милиона-двеста-и-двайсет")>]
[<InlineData(9099000, "девет-милиона-деветдесет-и-девет-хиляди")>]
[<InlineData(10000000, "десет-милиона")>]
[<InlineData(24000000, "двайсет-и-четири-милиона")>]
[<InlineData(39020011, "трийсет-и-девет-милиона-двайсет-хиляди-и-единайсет")>]
[<InlineData(40606100, "четиресет-милиона-шестстотин-и-шест-хиляди-и-сто")>]
[<InlineData(53000000, "петдесет-и-три-милиона")>]
[<InlineData(64000098, "шейсет-и-четири-милиона-деветдесет-и-осем")>]
[<InlineData(70003190, "седемдесет-милиона-три-хиляди-сто-и-деветдесет")>]
[<InlineData(80000000, "осемдесет-милиона")>]
[<InlineData(99000099, "деветдесет-и-девет-милиона-деветдесет-и-девет")>]
[<InlineData(100000000, "сто-милиона")>]
[<InlineData(209000000, "двеста-и-девет-милиона")>]
[<InlineData(398000000, "триста-деветдесет-и-осем-милиона")>]
[<InlineData(439011000, "четиристотин-трийсет-и-девет-милиона-и-единайсет-хиляди")>]
[<InlineData(560400000, "петстотин-и-шейсет-милиона-и-четиристотин-хиляди")>]
[<InlineData(600010900, "шестстотин-милиона-десет-хиляди-и-деветстотин")>]
[<InlineData(700000000, "седемстотин-милиона")>]
[<InlineData(800116000, "осемстотин-милиона-сто-и-шестнайсет-хиляди")>]
[<InlineData(900800007, "деветстотин-милиона-осемстотин-хиляди-и-седем")>]
[<InlineData(1000000000, "един-милиард")>]
[<InlineData(2121000000, "два-милиарда-сто-двайсет-и-един-милиона")>]
[<InlineData(System.Int32.MaxValue, 
             "два-милиарда-сто-четиресет-и-седем-милиона-четиристотин-осемдесет-и-три-хиляди-шестстотин-четиресет-и-седем")>]
let ``toBulgarian returns correct result`` (i, expected) = 
    let actual = Numeral.toBulgarian i
    expected =! actual
