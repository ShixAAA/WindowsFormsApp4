namespace WindowsFormsApp4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Идентификатор { get; set; }

        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Фамилия { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        [StringLength(50)]
        public string Паспорт { get; set; }

        [StringLength(50)]
        public string Почта { get; set; }

        [StringLength(50)]
        public string АдресРегистрации { get; set; }

        [StringLength(50)]
        public string АдресПроживания { get; set; }

        [StringLength(50)]
        public string МестоРаботы { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        [StringLength(50)]
        public string МобильныйТелефон { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Фотография { get; set; }

        [StringLength(50)]
        public string Замечания { get; set; }
    }
}
