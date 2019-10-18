// DocSection: importing_assets_create_asset
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertAsset()
  .withData(
    {
      fileReference: {
        id: '8660e19c-7bbd-48a3-bb51-721934c7756c',
        type: 'internal'
      },
      title: "Brno Cafe",
      assetExternalId: 'brno-cafe-image',
      descriptions: [
        {
          language: {
            codename: 'en-US'
          },
          description: 'Cafe in Brno'
        },
        {
          language: {
            codename: 'es-ES'
          },
          description: 'Café en Brno'
        }
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection