/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GetStateValidityRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/srv/GetStateValidity";

        public RobotState robot_state { get; set; }
        public string group_name { get; set; }
        public Constraints constraints { get; set; }

        public GetStateValidityRequest()
        {
            this.robot_state = new RobotState();
            this.group_name = "";
            this.constraints = new Constraints();
        }

        public GetStateValidityRequest(RobotState robot_state, string group_name, Constraints constraints)
        {
            this.robot_state = robot_state;
            this.group_name = group_name;
            this.constraints = constraints;
        }
    }
}
#endif