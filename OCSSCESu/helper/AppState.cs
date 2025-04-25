using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSSCESu.helper
{
    public class AppState
    {

        private static AppState _instance;

        public static AppState Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppState();
                }
                return _instance;
            }
        }


        private AppState()
        {
            // Candidate Table
            CandidatesTable.Columns.Add("candidate_id");
            CandidatesTable.Columns.Add("candidate_student_id");
            CandidatesTable.Columns.Add("candidate_full_name");
            CandidatesTable.Columns.Add("candidate_year_level");
            CandidatesTable.Columns.Add("candidate_course");
            CandidatesTable.Columns.Add("candidate_position");
            CandidatesTable.Columns.Add("candidate_image");


            // BallotTable

            BallotTable.Columns.Add("representative_id");
            BallotTable.Columns.Add("president_id");
            BallotTable.Columns.Add("VPIA_id");
            BallotTable.Columns.Add("VPEA_id");
            BallotTable.Columns.Add("secIA_id");
            BallotTable.Columns.Add("secEA_id");
            BallotTable.Columns.Add("treasurer_id");
            BallotTable.Columns.Add("auditor_id");
            BallotTable.Columns.Add("BM_id");
            BallotTable.Columns.Add("PRO_id");
            BallotTable.Columns.Add("course");
            BallotTable.Columns.Add("studentId");
            BallotTable.Columns.Add("yearLevel");


            // Student code

            StudentUniqueCodeTable.Columns.Add("student_id");
            StudentUniqueCodeTable.Columns.Add("student_full_name");
            StudentUniqueCodeTable.Columns.Add("student_year_level");
            StudentUniqueCodeTable.Columns.Add("student_course");
            StudentUniqueCodeTable.Columns.Add("student_unique_code");
            StudentUniqueCodeTable.Columns.Add("student_unique_code_status");
        }

        public DataTable CandidatesTable { get; set; } = new DataTable();
        public DataTable BallotTable { get; set; } = new DataTable();
        public DataTable StudentUniqueCodeTable { get; set; } = new DataTable();
    }
}
