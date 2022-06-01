using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class voltmeter : MonoBehaviour
{
    private float Max_voltage_angle = -20;
    private float Zero_voltage_angle = 210;

    private Transform needleTransform;
    private Transform voltageLabelTemplateTransform;

    private float voltageMax;
    private float voltage;


    private void Awake(){
        needleTransform = transform.Find("needle");
        voltageLabelTemplateTransform = transform.Find("voltage_label_tamplate");
        voltageLabelTemplateTransform.gameObject.SetActive(false);

        voltage = 0f;
        voltageMax = 690f;

        CreateVoltageLables();

    }

    // Update is called once per frame
    private void Update()
    {
        if (voltage <= 620) voltage += 30f * Time.deltaTime;
        
        needleTransform.eulerAngles = new Vector3(0, 0, GetVoltageRotation());
        
    }


    private void CreateVoltageLables() {
        int labelAmount = 8;
        float totalAngleSize = Zero_voltage_angle -Max_voltage_angle;

        for (int i = 0; i <= labelAmount; i++) {
            Transform voltaLabelTransform = Instantiate(voltageLabelTemplateTransform, transform);
            float labelVoltageNormalized = (float)i / labelAmount;
            float voltageLabelAngle = Zero_voltage_angle - labelVoltageNormalized * totalAngleSize;
            voltaLabelTransform.eulerAngles = new Vector3(0, 0, voltageLabelAngle);
            voltaLabelTransform.Find("voltageText").GetComponent<Text>().text = Mathf.RoundToInt(labelVoltageNormalized * voltageMax).ToString();
            voltaLabelTransform.Find("voltageText").eulerAngles = Vector3.zero;
            voltaLabelTransform.gameObject.SetActive(true);
        }

        needleTransform.SetAsLastSibling();

    }

    private float GetVoltageRotation() {

        float totalAngleSize = Zero_voltage_angle -Max_voltage_angle;

        float voltageNormalized = voltage / voltageMax;

        return Zero_voltage_angle - voltageNormalized * totalAngleSize;
    }

}
