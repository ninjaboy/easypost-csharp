﻿namespace EasyPost {
    public class Fee : Resource {
        public string type { get; set; }
        public double amount { get; set; }
        public bool charged { get; set; }
        public bool refunded { get; set; }
    }
}
