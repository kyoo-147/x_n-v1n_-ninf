namespace test1;

class AudiCarBuilder:VehicleBuilder
{
    public AudiCarBuilder()
        {
            vehicle = new Vehicle("Xe Audi");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Khung Xe Audi";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "500 Phân Khối";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

}















