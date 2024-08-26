using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemManager.Entities
{

    public class Machine
    {
        [Key]
        public int Tag { get; set; }
        
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public string ModelName { get; set; }
        public int SerialNumber { get; set; }
        public int RamMemory { get; set; }
        public int RomMemory { get; set; }
        public bool HavePipaUser { get; set; }

        public Machine()
        {
        }

        public Machine(int tag, Guid userId, string modelName, int serialNumber, int ramMemory, int romMemory, bool havePipaUser)
        {
            Tag = tag;
            UserId = userId;
            ModelName = modelName;
            SerialNumber = serialNumber;
            RamMemory = ramMemory;
            RomMemory = romMemory;
            HavePipaUser = havePipaUser;
        }


        public override string ToString()
        {
            return $@"
        {Tag}
        {UserId}
        {ModelName}
        {SerialNumber}
        {RamMemory}
        {RomMemory}
        {HavePipaUser}
        ";
        }


    }
}