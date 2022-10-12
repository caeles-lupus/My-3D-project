using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Spawn SpawnInstance;
    public Moving MovingInstance;

    public TMP_InputField FieldSpeed;
    public TMP_InputField FieldDistance;
    public TMP_InputField FieldRespawn;
    // Start is called before the first frame update
    void Start()
    {
        FieldSpeed.text = MovingInstance.Speed.ToString();
        FieldDistance.text = MovingInstance.Distance.ToString();
        FieldRespawn.text = SpawnInstance.ReloadTimeSec.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float movSpeed = float.TryParse(FieldSpeed.text, out movSpeed) ? (float)movSpeed : 0;
        if (movSpeed != 0 && MovingInstance.Speed != movSpeed)
            MovingInstance.Speed = movSpeed;

        float movDistance = float.TryParse(FieldDistance.text, out movDistance) ? (float)movDistance : 0;
        if (movDistance != 0 && MovingInstance.Distance != movDistance)
            MovingInstance.Distance = movDistance;

        float movRespawn = float.TryParse(FieldRespawn.text, out movRespawn) ? (float)movRespawn : 0;
        if (movRespawn!= 0 && SpawnInstance.ReloadTimeSec != movRespawn)
            SpawnInstance.ReloadTimeSec = movRespawn;
    }
}
