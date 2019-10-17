using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class FlowerType : List<Flower>
    {
        public string typeName { get; set; }
        public FlowerType(string flowerType)
        {
            typeName = flowerType;
        }

        public IList<FlowerType> flowerTypes { get; set; }

        public FlowerType()
        {
            List<FlowerType> l = new List<FlowerType>
            {
                new FlowerType("Hoa cúc")
                {
                    new Flower{flowerName="Đón Xuân",price=50000,imageName="cuc_9.jpg"},
                    new Flower{flowerName="Hồn nhiên",price=60000,imageName="cuc_2.jpg"},
                    new Flower{flowerName="Tím thủy chung",price=45000,imageName="cuc_3.jpg"}
                },
                new FlowerType("Hoa cưới")
                {
                    new Flower{flowerName="Dây tơ hồng",price=250000,imageName="cuoi_1.jpg"},
                    new Flower{flowerName="Cầu thủy tinh",price=220000,imageName="cuoi_2.jpg"},
                    new Flower{flowerName="Duyên thầm",price=260000,imageName="cuoi_3.jpg"},
                }
            };

            flowerTypes = l;
        }
    }
}
