using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalParks.Models
{

    public class Parks
    {
        public Meta meta { get; set; }
        public Result[] results { get; set; }
    }

    public class Meta
    {
        public string disclaimer { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string last_updated { get; set; }
        public Results results { get; set; }
    }

    public class Results
    {
        public int skip { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
    }

    public class Result
    {
        public Reaction[] reaction { get; set; }
        public Receiver receiver { get; set; }
        public string unique_aer_id_number { get; set; }
        public string original_receive_date { get; set; }
        public string number_of_animals_affected { get; set; }
        public string primary_reporter { get; set; }
        public string number_of_animals_treated { get; set; }
        public Drug[] drug { get; set; }
        public string onset_date { get; set; }
        public Health_Assessment_Prior_To_Exposure health_assessment_prior_to_exposure { get; set; }
        public string report_id { get; set; }
        public Animal animal { get; set; }
        public string type_of_information { get; set; }
        public Outcome[] outcome { get; set; }
        public string serious_ae { get; set; }
        public string treated_for_ae { get; set; }
        public Duration duration { get; set; }
        public string secondary_reporter { get; set; }
    }

    public class Receiver
    {
        public string country { get; set; }
        public string street_address { get; set; }
        public string city { get; set; }
        public string organization { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
    }

    public class Health_Assessment_Prior_To_Exposure
    {
        public string assessed_by { get; set; }
        public string condition { get; set; }
    }

    public class Animal
    {
        public string gender { get; set; }
        public string species { get; set; }
        public Weight weight { get; set; }
        public Age age { get; set; }
        public Breed breed { get; set; }
        public string reproductive_status { get; set; }
        public string female_animal_physiological_status { get; set; }
    }

    public class Weight
    {
        public string qualifier { get; set; }
        public string unit { get; set; }
        public string min { get; set; }
    }

    public class Age
    {
        public string qualifier { get; set; }
        public string unit { get; set; }
        public string min { get; set; }
    }

    public class Breed
    {
        public string is_crossbred { get; set; }
        public object breed_component { get; set; }
    }

    public class Duration
    {
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Reaction
    {
        public string veddra_term_code { get; set; }
        public string number_of_animals_affected { get; set; }
        public string veddra_version { get; set; }
        public string accuracy { get; set; }
        public string veddra_term_name { get; set; }
    }

    public class Drug
    {
        public string route { get; set; }
        public Active_Ingredients[] active_ingredients { get; set; }
        public string brand_name { get; set; }
        public string lot_number { get; set; }
        public string lot_expiration { get; set; }
        public string atc_vet_code { get; set; }
        public string dosage_form { get; set; }
        public Manufacturer manufacturer { get; set; }
        public string first_exposure_date { get; set; }
        public string administered_by { get; set; }
        public string last_exposure_date { get; set; }
        public string previous_exposure_to_drug { get; set; }
        public Dose dose { get; set; }
        public string used_according_to_label { get; set; }
        public object off_label_use { get; set; }
        public string previous_ae_to_drug { get; set; }
        public string ae_reappeared_after_resuming_drug { get; set; }
        public Frequency_Of_Administration frequency_of_administration { get; set; }
    }

    public class Manufacturer
    {
        public string registration_number { get; set; }
        public string name { get; set; }
    }

    public class Dose
    {
        public string denominator_unit { get; set; }
        public string numerator_unit { get; set; }
        public string denominator { get; set; }
        public string numerator { get; set; }
    }

    public class Frequency_Of_Administration
    {
        public string unit { get; set; }
        public string value { get; set; }
    }

    public class Active_Ingredients
    {
        public Dose1 dose { get; set; }
        public string name { get; set; }
    }

    public class Dose1
    {
        public string denominator_unit { get; set; }
        public string numerator_unit { get; set; }
        public string denominator { get; set; }
        public string numerator { get; set; }
    }

    public class Outcome
    {
        public string medical_status { get; set; }
        public string number_of_animals_affected { get; set; }
    }


}
