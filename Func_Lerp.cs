// 如果光的强度从 0 开始，则在第一次更新后，其值将设置为 4。下一帧会将其设置为 6，然后设置为 7，再然后设置为 7.5，依此类推。
void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}

// 强度变化将按每秒而不是每帧发生
void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}
